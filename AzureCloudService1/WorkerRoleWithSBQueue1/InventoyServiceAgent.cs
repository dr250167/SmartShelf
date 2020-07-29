using ImDao;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkerRoleWithSBQueue1
{
    public class InventoyServiceAgent
    {
        public void SendToInventory(object obj)
        {

            InventoryMessage inventoryMessage = (InventoryMessage)obj ;
            InventoryRequest request = GenerateHeader(inventoryMessage.BusinessUnit);

            BuildLine(request, inventoryMessage.ProductId, inventoryMessage.Inventoy);
            ImWrapper imWrapper = new ImWrapper();
            string message;
            XmlSerializer x = new XmlSerializer(request.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(textWriter, request);
                message = textWriter.ToString();
            }
            imWrapper.Execute(message);
        }


        private void BuildLine(InventoryRequest request, string id, string quantity)
        {
            var a = new DateTime() { TypeCode = "EffectiveDate", Value = System.DateTime.Now.ToString("o") };
            request.InventoryAction[0].InventoryItem[0] = new InventoryRequestInventoryActionInventoryItemInventoryPackage();
            request.InventoryAction[0].InventoryItem[0].Operator = "Hack";
            request.InventoryAction[0].InventoryItem[0].Package = id;
            request.InventoryAction[0].InventoryItem[0].Quantity = quantity;
            request.InventoryAction[0].InventoryItem[0].DateTime = new DateTime[] { a };
        }

        private InventoryRequest GenerateHeader(string businessUnit)
        {
            var a = new DateTime() { TypeCode = "EffectiveDate", Value = System.DateTime.Now.ToString("o") };
            var b = new DateTime() { TypeCode = "CreationDate", Value = System.DateTime.Now.ToString("o") };
            InventoryRequest request = new InventoryRequest();
            request.FixVersion = "0";
            request.MajorVersion = "0";
            request.MinorVersion = "0";
            request.InventoryAction = new InventoryRequestInventoryAction[1];
            request.InventoryAction[0] = new InventoryRequestInventoryAction();
            request.InventoryAction[0].Action = "Save";
            request.InventoryAction[0].Type = "StockCount";
            request.InventoryAction[0].Id = Guid.NewGuid().ToString();
            request.InventoryAction[0].Description = "Hackathon";
            request.InventoryAction[0].DateTime = new DateTime[2];
            request.InventoryAction[0].DateTime[0] = a;
            request.InventoryAction[0].DateTime[1] = b;

            request.InventoryAction[0].ApproveOperator = "System";
            request.InventoryAction[0].Scope = new InventoryRequestInventoryActionScopeInventoryLocation[] { new InventoryRequestInventoryActionScopeInventoryLocation() { BusinessUnit = businessUnit } };
            request.InventoryAction[0].InventoryItem = new InventoryRequestInventoryActionInventoryItemInventoryPackage[1];

            return request;
        }
    }
}
