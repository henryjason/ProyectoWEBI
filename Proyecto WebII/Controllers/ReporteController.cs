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
    public class ReporteController : Controller
    {
        private AppDB db = new AppDB();
        // GET: /Reporte/

        public ActionResult report(int id)
        {

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select *");
            sql.AppendLine("from reportes reports");
            sql.AppendLine("where reports.id = @id");
            var report = db.Database.SqlQuery<reportes>(sql.ToString(), new SqlParameter("id", id)).ToList();
            ViewBag.reporte = report.ToList();

   

            return View();
        }

       
             [HttpPost]
        public int register_reporte(string result, int id_user)
        {
   

            reportes oReporte = new reportes();
            oReporte.id_user = id_user;
            oReporte.result = result;

            if (ModelState.IsValid)
            {    
                db.oReportes.Add(oReporte);
                db.SaveChanges();

            }

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select TOP 1 *");
            sql.AppendLine("from reportes");
            sql.AppendLine("ORDER BY id DESC");
            var report = db.Database.SqlQuery<reportes>(sql.ToString()).ToList();
            ViewBag.reporte = report.ToList();

                 var id =  ViewBag.reporte[0].id;

            return id;

        }



    }
}
