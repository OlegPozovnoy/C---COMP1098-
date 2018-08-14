using System;
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
    public class VehiclesController : Controller
    {
        private VehicleModel db = new VehicleModel();

        // GET: Vehicles
        public ActionResult Index()
        {
            var vehicles = db.Vehicles.Include(v => v.Make).Include(v => v.Model);
            return View(vehicles.ToList());
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            Vehicle v = new Vehicle() { CreateDate = DateTime.Now, EditDate = DateTime.Now };
            ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name");
            ViewBag.ModelId = new SelectList(db.Models, "ModelId", "ModelId");
            return View(v);
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleId,MakeId,ModelId,Year,Price,Cost,SoldDate,isSold,CreateDate,EditDate")] Vehicle vehicle)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.Vehicles.Add(vehicle);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name", vehicle.MakeId);
                ViewBag.ModelId = new SelectList(db.Models, "ModelId", "ModelId", vehicle.ModelId);
                return View(vehicle);
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "VehiclesController", "Create"));
            }


        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            vehicle.EditDate = DateTime.Now;
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name", vehicle.MakeId);
            ViewBag.ModelId = new SelectList(db.Models, "ModelId", "ModelId", vehicle.ModelId);
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleId,MakeId,ModelId,Year,Price,Cost,SoldDate,isSold,CreateDate,EditDate")] Vehicle vehicle)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(vehicle).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name", vehicle.MakeId);
                ViewBag.ModelId = new SelectList(db.Models, "ModelId", "ModelId", vehicle.ModelId);
                return View(vehicle);
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "VehiclesController", "Edit"));
            }
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {

            try { 
                    Vehicle vehicle = db.Vehicles.Find(id);
                    db.Vehicles.Remove(vehicle);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "VehiclesController", "Delete"));
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
