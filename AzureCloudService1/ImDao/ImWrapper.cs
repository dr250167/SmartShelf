using Retalix.StoreServices.ClientLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImDao
{
    public class ImWrapper
    {
        RemoteServer _remoteServer = new RemoteServer("amir", "123456", "https://daxdemo.swenglabs.ncr.com:8443/StoreWebServices");
        public ImWrapper()
        {
           
            _remoteServer = new RemoteServer("amir", "123456", "https://daxdemo.swenglabs.ncr.com:8443/StoreWebServices");
           
        }

        public void Execute(string message)
        {
            _remoteServer.ExecuteServiceOnRemoteServer(message, "SaveExternalStockCountDocument");
        }
    }
}
