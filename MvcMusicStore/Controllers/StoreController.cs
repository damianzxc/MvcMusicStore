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

        // Get /Store/Browse?genre=Disco
        public String Browse(String genre)
        {
            // HttpUtility.HtmlEncode prevent for spript injection in url
            String message = HttpUtility.HtmlEncode(";Store.Browse, Genre = "+ genre);
            return message;
        }

        // Get /Store/Details/id
        public String Details(int id)
        {
            String message = "Store.Details, ID =" + id;
            return message;
        }
    }
}
