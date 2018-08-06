﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNETCOMP2084.Models;

namespace ASPNETCOMP2084.Controllers
{
    public class StoreManagerController : Controller
    {
        private MusicStoreModel db = new MusicStoreModel();

        // GET: StoreManager
        public ActionResult Index()
        {
            var albums = db.Albums.Include(a => a.Artist).Include(a => a.Genre).OrderBy( a => a.AlbumName);

            ViewBag.count = albums.Count();

            return View(albums.ToList().OrderBy( a => a.Artist.Artist1).ThenBy( a => a.AlbumName));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Title)//var name should match the name of the Input
        {
            var albums = from a in db.Albums
                         where a.AlbumName.Contains(Title)
                         orderby a.Artist.Artist1, a.AlbumName
                         select a;

            ViewBag.count = albums.Count();
            return View(albums);
        }


        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.ArtistId = new SelectList(db.Artists.OrderBy(a => a.Artist1), "Id", "Artist1");
            ViewBag.GenreId = new SelectList(db.Genres.OrderBy(g => g.genre1), "Id", "genre1");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GenreId,ArtistId,AlbumName,price,AlbumArtistUrl")] Album album)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];

                    if (file.FileName != null & file.ContentLength > 0)
                    {
                        string path = Server.MapPath("/Content/Images/") + file.FileName;
                        file.SaveAs(path);
                        album.AlbumArtistUrl = "/Content/Images/" + file.FileName;
                    }
                }


                db.Albums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Artist1", album.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "genre1", album.GenreId);
            return View(album);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Artist1", album.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "genre1", album.GenreId);
            return View(album);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GenreId,ArtistId,AlbumName,price,AlbumArtistUrl")] Album album)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];

                    if (file.FileName != null & file.ContentLength > 0)
                    {
                        string path = Server.MapPath("/Content/Images/") + file.FileName;
                        file.SaveAs(path);
                        album.AlbumArtistUrl = "/Content/Images/" + file.FileName;
                    }
                }

                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "Artist1", album.ArtistId);
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "genre1", album.GenreId);
            return View(album);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Album album = db.Albums.Find(id);
            db.Albums.Remove(album);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
