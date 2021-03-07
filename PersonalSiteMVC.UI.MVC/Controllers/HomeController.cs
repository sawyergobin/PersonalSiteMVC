using PersonalSiteMVC.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PersonalSiteMVC.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public JsonResult ContactAjax(ContactViewModel cvm)
        {
            //This is the body of the message sent
            string body = $"{cvm.Name} has sent you the following message: <br />" +
                $"{cvm.Message} <br /> " +
                $"<strong>from the email address: {cvm.Email}</strong> ";

            MailMessage m = new MailMessage("admin@sawyergobin.com", "sawyergobin@outlook.com", cvm.Subject, body);

            m.IsBodyHtml = true;
            m.Priority = MailPriority.High;
            m.ReplyToList.Add(cvm.Email);

            SmtpClient client = new SmtpClient("mail.sawyergobin.com");
            //credentials
            //++++++++++++++++++++++++++++++SENSITIVE CREDENTIALS: REMOVE BEFORE MAKING REPO PUBLIC+++++++++++++++++++++
            client.Credentials = new NetworkCredential("admin@sawyergobin.com", "XWv8Mqe6Wt_");

            try
            {
                //send mail
                client.Send(m);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.StackTrace;
            }

            return Json(cvm);

        }
        
    }
}