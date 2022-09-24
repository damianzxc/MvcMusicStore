using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // Get /Store/
        public String Index()
        {
            return "Hello from Store.Index()";
        }

        // Get /Store/Browse
        public String Browse()
        {
            return "Hello from Store.Browse()";
        }

        // Get /Store/Details
        public String Details()
        {
            return "Hello from Store.Details()";
        }
    }
}
