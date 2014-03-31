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
    public class LoginController : Controller
    {

        private AppDB db = new AppDB();
       
        // GET: /Login/

        public ActionResult Login_user()
        {
            return View();
        }

        public ActionResult register()
        {
            return View();
        }

       

        [HttpPost]
        public ActionResult register_user(string name, string telefono, string email, string username, string pass)
        {
     

            Login_Register oRegister = new Login_Register();
            oRegister.name = name;
            oRegister.telefono = telefono;
            oRegister.email = email;
            oRegister.username = username;
            oRegister.pass = pass;

            if (ModelState.IsValid)
            {
                db.oLogin_Register.Add(oRegister);
                db.SaveChanges();

            }
            return Json(new { value = "true" }); ;
        }


        public ActionResult index(string username, string pass)
        {
            
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select *");
            sql.AppendLine("from Login_Register login");
            sql.AppendLine("where login.username = @username and ");
            sql.AppendLine("login.pass = @pass ");
            var prueba = db.Database.SqlQuery<Login_Register>(sql.ToString(), new SqlParameter("username", username), new SqlParameter("pass", pass)).ToList();
            ViewBag.prueba = prueba.ToList();

            if (prueba.ToList().Count == 0)
            {
                return RedirectToAction("Login_user");
            }

            //return RedirectToAction("prueba");

            return View();

        }



    }
}
