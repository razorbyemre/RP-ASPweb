using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLL.Models;
using RP_ASPweb.Data;

namespace RP_ASPweb.Controllers
{
    public class SuplierModelsController : Controller
    {
        private RP_ASPwebContext db = new RP_ASPwebContext();

        // GET: SuplierModels
        public ActionResult Index()
        {
            return View(db.SuplierModels.ToList());
        }

        // GET: SuplierModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuplierModel suplierModel = db.SuplierModels.Find(id);
            if (suplierModel == null)
            {
                return HttpNotFound();
            }
            return View(suplierModel);
        }

        // GET: SuplierModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuplierModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CompanyName,ContactName")] SuplierModel suplierModel)
        {
            if (ModelState.IsValid)
            {
                db.SuplierModels.Add(suplierModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suplierModel);
        }

     

        // GET: SuplierModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuplierModel suplierModel = db.SuplierModels.Find(id);
            if (suplierModel == null)
            {
                return HttpNotFound();
            }
            return View(suplierModel);
        }

        // POST: SuplierModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuplierModel suplierModel = db.SuplierModels.Find(id);
            db.SuplierModels.Remove(suplierModel);
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
