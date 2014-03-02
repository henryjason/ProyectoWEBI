using Proyecto_WebI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_WebI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email()
        {
            return View();
        }

        public ActionResult SendMail(string Subject,string name, string from, string Body)
        {


            EMail oMail = new EMail();
            EMail.Send("maps.gplaces@gmail.com", Subject +  " -> " + " (" + name + ") " + from, from, Body );

            return Content("Success");
        }

        

    }
}
