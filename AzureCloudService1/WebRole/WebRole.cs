using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Newtonsoft.Json;

namespace WebRole
{
    public class WebRole : RoleEntryPoint
    {
        Queue<object> queue;
        Microsoft.ServiceBus.Messaging.QueueClient Client;
        ManualResetEvent CompletedEvent = new ManualResetEvent(false);
        const string QueueName = "SmartShelf";

        // QueueClient is thread-safe. Recommended that you cache 
        // rather than recreating it on every request
        
        public WebRole()
        {
            queue = new Queue<object>();
        }

        public void AddMessage(object message)
        {
            queue.Enqueue(message);
        }
        public void Send()
        {
            if (Client == null) { OnStart(); }
            if (queue.Count > 0)
            {
                var message = queue.Dequeue();
                string messageBody = JsonConvert.SerializeObject(message);
                BrokeredMessage queueMessage = new BrokeredMessage(Encoding.UTF8.GetBytes(messageBody));

                Client.Send(queueMessage);


                Trace.WriteLine(string.Format("sending meesage {0} ", messageBody));
            }
        }
        public override void Run()
        {
            
            base.Run();
        }
        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections 
            ServicePointManager.DefaultConnectionLimit = 12;

            // Create the queue if it does not exist already
            string connectionString = System.Configuration.ConfigurationManager.AppSettings["Microsoft.ServiceBus.ConnectionString"];
            var namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);
            if (!namespaceManager.QueueExists(QueueName))
            {
                namespaceManager.CreateQueue(QueueName);
            }

            // Initialize the connection to Service Bus Queue
            Client = QueueClient.CreateFromConnectionString(connectionString, QueueName);
            return base.OnStart();
        }
    }
}
