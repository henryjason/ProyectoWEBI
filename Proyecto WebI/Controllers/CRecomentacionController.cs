using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_WebI.Models;

namespace Proyecto_WebI.Controllers
{
    public class CRecomentacionController : Controller
    {
        private DBRecomentaciones db = new DBRecomentaciones();

        //
        // GET: /CRecomentacion/

        public ActionResult Index()
        {
            return View(db.oRecomendacion.ToList());
        }

        //
        // GET: /CRecomentacion/Details/5

        public ActionResult Details(int id = 0)
        {
            Recomentacion recomentacion = db.oRecomendacion.Find(id);
            if (recomentacion == null)
            {
                return HttpNotFound();
            }
            return View(recomentacion);
        }

        //
        // GET: /CRecomentacion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CRecomentacion/Create

        [HttpPost]
        public ActionResult Create(Recomentacion recomentacion)
        {
            if (ModelState.IsValid)
            {
                db.oRecomendacion.Add(recomentacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recomentacion);
        }

        //
        // GET: /CRecomentacion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Recomentacion recomentacion = db.oRecomendacion.Find(id);
            if (recomentacion == null)
            {
                return HttpNotFound();
            }
            return View(recomentacion);
        }

        //
        // POST: /CRecomentacion/Edit/5

        [HttpPost]
        public ActionResult Edit(Recomentacion recomentacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recomentacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recomentacion);
        }

        //
        // GET: /CRecomentacion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Recomentacion recomentacion = db.oRecomendacion.Find(id);
            if (recomentacion == null)
            {
                return HttpNotFound();
            }
            return View(recomentacion);
        }

        //
        // POST: /CRecomentacion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Recomentacion recomentacion = db.oRecomendacion.Find(id);
            db.oRecomendacion.Remove(recomentacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}