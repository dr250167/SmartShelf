using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebRole.Controllers
{
    public class IMMessageController : ApiController
    {

        // POST: IMMessage/Create
        public void Post([FromBody]InventoryMessage value)
        {
            WebRole webRole = new WebRole();
            webRole.AddMessage(value);
            webRole.Send();
        }
        
    }
}
