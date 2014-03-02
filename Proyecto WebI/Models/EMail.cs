using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Xml;

namespace Proyecto_WebI.Models
{
    public class EMail
    {

        private string FromAddress;
        private string strToAddress;
        private string strSmtpClient;
        private string UserID;
        private string Password;
        private string ReplyTo;
        private string SMTPPort;
        private Boolean bEnableSSL;

        private void InitMail()
        {
            FromAddress = System.Configuration.ConfigurationManager.AppSettings.Get("FromAddress");
            strToAddress = System.Configuration.ConfigurationManager.AppSettings.Get("ToAddress");
            //strSmtpClient = System.Configuration.ConfigurationManager.AppSettings.Get("SmtpClient");
            strSmtpClient = "smtp.live.com";
            UserID = System.Configuration.ConfigurationManager.AppSettings.Get("UserID");
            Password = System.Configuration.ConfigurationManager.AppSettings.Get("Password");
            ReplyTo = System.Configuration.ConfigurationManager.AppSettings.Get("ReplyTo");
            SMTPPort = System.Configuration.ConfigurationManager.AppSettings.Get("SMTPPort");
            if (System.Configuration.ConfigurationManager.AppSettings.Get("EnableSSL").ToUpper() == "YES")
            {
                bEnableSSL = true;
            }
            else
            {
                bEnableSSL = false;
            }
        }

        public static void Send(string toAddress, string subject, string from, string body)
        {
            var mailMessage = new MailMessage();
            mailMessage.To.Add(toAddress);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;

            var smtpClient = new SmtpClient { EnableSsl = true };
            smtpClient.Send(mailMessage);


            var mailMessageR = new MailMessage();
            mailMessageR.To.Add(from);
            mailMessageR.Subject = subject;
            mailMessageR.Body = "autoresponder: \n Gracias Por su recomentacion \n Atte: GPlaceS ";
            mailMessageR.IsBodyHtml = true;

            var smtpClientR = new SmtpClient { EnableSsl = true };
            smtpClientR.Send(mailMessageR);

        }

    }


}
