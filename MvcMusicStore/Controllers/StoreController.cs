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

        MusicStoreEntities storeDb = new MusicStoreEntities();

        public ActionResult Index()
        {
            var genres = storeDb.Genres.ToList();
            return View(genres);
        }

        // Get /Store/Browse?genre=Disco
        public ActionResult Browse(String genre)
        {
            // HttpUtility.HtmlEncode prevent for spript injection in url
            //String message = HttpUtility.HtmlEncode(";Store.Browse, Genre = "+ genre);

            var genreModel = storeDb.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }

        // Get /Store/Details/id
        public ActionResult Details(int id)
        {
            var album = storeDb.Albums.Find(id);
            return View(album);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDb.Genres.ToList();
            return PartialView(genres);
        }
    }
}
