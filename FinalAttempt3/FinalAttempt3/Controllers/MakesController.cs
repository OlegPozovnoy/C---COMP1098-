﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalAttempt3.Models;

namespace FinalAttempt3.Controllers
{
    public class MakesController : Controller
    {
        private VehicleModel db = new VehicleModel();

        // GET: Makes
        public ActionResult Index()
        {
            return View(db.Makes.ToList());
        }

        // GET: Makes/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Make make = db.Makes.Find(id);
            if (make == null)
            {
                return HttpNotFound();
            }
            return View(make);
        }

        // GET: Makes/Create
        public ActionResult Create()
        {
            Make item = new Make() { CreateDate = DateTime.Now, EditDate = DateTime.Now };
            return View(item);
        }

        // POST: Makes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MakeId,Name,CreateDate,EditDate")] Make make)
        {
            try { 

                    if (ModelState.IsValid)
                    {
                        db.Makes.Add(make);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }

                    return View(make);

            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "MakesController", "Create"));
            }

}

        // GET: Makes/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Make make = db.Makes.Find(id);
            make.EditDate = DateTime.Now;
            if (make == null)
            {
                return HttpNotFound();
            }
            return View(make);
        }

        // POST: Makes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MakeId,Name,CreateDate,EditDate")] Make make)
        {

            try { 
                    if (ModelState.IsValid)
                    {
                        db.Entry(make).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    return View(make);

                }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "MakesController", "Edit"));
            }

}

        // GET: Makes/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Make make = db.Makes.Find(id);
            if (make == null)
            {
                return HttpNotFound();
            }
            return View(make);
        }

        // POST: Makes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {

            try { 
            Make make = db.Makes.Find(id);
            db.Makes.Remove(make);
            db.SaveChanges();
            return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "MakesController", "Delete"));
            }



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
