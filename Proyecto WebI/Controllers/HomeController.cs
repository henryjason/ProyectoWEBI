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

        public ActionResult SendMail(string Subject, string Body)
        {


            EMail oMail = new EMail();
            EMail.Send("henryjason2009@hotmail.com", Subject, Body );

            return Content("Success");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Sendlink(FormCollection formCollection)
        {
            try
            {

                var mailMessage = new MailMessage();
                mailMessage.To.Add("henryjason2009@hotmail.com");
                mailMessage.Subject = "como estas";
                mailMessage.Body = "como";
                mailMessage.IsBodyHtml = true;

                var smtpClient = new SmtpClient { EnableSsl = true };
                smtpClient.Send(mailMessage);
            }
            catch
            {

            }
            return null;
        }

    }
}
