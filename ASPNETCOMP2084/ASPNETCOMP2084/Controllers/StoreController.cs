using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETCOMP2084.Models;

namespace ASPNETCOMP2084.Controllers
{
    public class StoreController : Controller
    {

        MusicStoreModel db = new MusicStoreModel();
        // GET: Store
        public ActionResult Index()
        {
            //var genres = new List<TestGenres>();

            //for (int i = 1; i <= 10; i++)
            //    genres.Add(new TestGenres { Name = "Genre" + i.ToString() });


            var genres = db.Genres.ToList();

            return View(genres);
        }

        public ActionResult Browse(string genre)
        {

            var g = db.Genres.Include("Albums")
                .SingleOrDefault(gn => gn.genre1 == genre);
            ViewBag.genre = genre;
            return View(g);
        }
    }
}