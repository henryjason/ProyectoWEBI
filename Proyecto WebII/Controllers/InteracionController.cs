using Proyecto_WebII.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
        public ActionResult register_Interacion(int id_user, string name, string url, string action, string verb, string pa_va)
        {


            Interacions oInteracion = new Interacions();
            oInteracion.id_user = id_user;
            oInteracion.name = name;
            oInteracion.url = url;
            oInteracion.action = action;
            oInteracion.verb = verb;
            oInteracion.parametro = pa_va;
            

            if (ModelState.IsValid)
            {
                db.oInteracion.Add(oInteracion);
                db.SaveChanges();

            }

            return get_Interacion(id_user);
        }

        [HttpPost]
        public ActionResult get_Interacion(int id_user)
        {

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select *");
            sql.AppendLine("from Interacions inter");
            sql.AppendLine("where inter.id_user = @id_user");
            var Iteracion = db.Database.SqlQuery<Interacions>(sql.ToString(), new SqlParameter("id_user", id_user)).ToList();
            ViewBag.iteracion = Iteracion.ToList();


            var a = Json(new { Iteracion });
            return a;

            //return Iteracion;

        }

    }
}
