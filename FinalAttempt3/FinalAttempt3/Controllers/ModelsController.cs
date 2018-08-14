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
    public class ModelsController : Controller
    {
        private VehicleModel db = new VehicleModel();

        // GET: Models
        public ActionResult Index()
        {
            var models = db.Models.Include(m => m.VehicleType);
            return View(models.ToList());
        }

        // GET: Models/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Models.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: Models/Create
        public ActionResult Create()
        {

            Model m = new Model() { CreateDate = DateTime.Now, EditDate = DateTime.Now };
            ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "VehicleTypeId", "VehicleTypeName");
            return View(m);
        }

        // POST: Models/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ModelId,EngineSize,NumberOfDoors,Colour,VehicleTypeId,CreateDate,EditDate")] Model model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    db.Models.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "VehicleTypeId", "VehicleTypeName", model.VehicleTypeId);
                return View(model);

            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "ModelsController", "Create"));
            }
}

        // GET: Models/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Model model = db.Models.Find(id);
            model.EditDate = DateTime.Now;
            if (model == null)
            {
                return HttpNotFound();
            }
            ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "VehicleTypeId", "VehicleTypeName", model.VehicleTypeId);
            return View(model);
        }

        // POST: Models/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ModelId,EngineSize,NumberOfDoors,Colour,VehicleTypeId,CreateDate,EditDate")] Model model)
        {
            try
            { 
                if (ModelState.IsValid)
                {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
                }
                ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "VehicleTypeId", "VehicleTypeName", model.VehicleTypeId);
                return View(model);
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "ModelsController", "Edit"));
            }
}

        // GET: Models/Delete/5
        public ActionResult Delete(decimal id)
        {

                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    Model model = db.Models.Find(id);
                    if (model == null)
                    {
                        return HttpNotFound();
                    }
                    return View(model);

        }

        // POST: Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {

            try { 
                Model model = db.Models.Find(id);
                db.Models.Remove(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) ex = ex.InnerException;
                return View("Error", new HandleErrorInfo(ex, "ModelsController", "Delete"));
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
