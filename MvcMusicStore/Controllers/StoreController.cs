using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // Get /Store/
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);
        }

        // Get /Store/Browse?genre=Disco
        public ActionResult Browse(String genre)
        {
            // HttpUtility.HtmlEncode prevent for spript injection in url
            //String message = HttpUtility.HtmlEncode(";Store.Browse, Genre = "+ genre);

            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }

        // Get /Store/Details/id
        public ActionResult Details(int id)
        {
            //String message = "Store.Details, ID =" + id;
            var album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}
