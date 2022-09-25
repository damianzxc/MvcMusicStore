using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {

        private MusicStoreEntities storeDb = new MusicStoreEntities();

        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }

        private List<Album> GetTopSellingAlbums(int count)
        { 
            return storeDb.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}
