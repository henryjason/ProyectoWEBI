using Proyecto_WebII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_WebII.Controllers
{
    public class InteracionController : Controller
    {
        //
        // GET: /Interacion/
        private AppDB db = new AppDB();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult register_Interacion(int id_user, string name, string url, string action, string verb)
        {


            Interacion oInteracion = new Interacion();
            oInteracion.id_user = id_user;
            oInteracion.name = name;
            oInteracion.url = url;
            oInteracion.action = action;
            oInteracion.verb = verb;
            

            if (ModelState.IsValid)
            {
                db.oInteracion.Add(oInteracion);
                db.SaveChanges();

            }
            return Json(new { value = "true" }); ;
        }

    }
}
