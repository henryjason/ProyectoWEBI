using Proyecto_WebII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_WebII.Controllers
{
    public class ReporteController : Controller
    {
        private AppDB db = new AppDB();
        // GET: /Reporte/

        public ActionResult report()
        {
            return View();
        }

       
             [HttpPost]
        public ActionResult register_reporte(string result, int id_user)
        {


            reportes oReporte = new reportes();
            oReporte.id_user = id_user;
            oReporte.result = result;

            if (ModelState.IsValid)
            {
                db.oReportes.Add(oReporte);
                db.SaveChanges();

            }

            return null;
        }

    }
}
