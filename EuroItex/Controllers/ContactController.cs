using Simplify.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace EuroItex.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send()
        {
            var name = Request["name"];
            var email = Request["email"];
            var phone = "/";
            var company = "/";

            if (Request["phone"] != null)                  
            {
                phone = Request["phone"];
            }

            if (Request["company"] != null)
   
            {
                company = Request["company"];
            }



            var fromAddress = new MailAddress(email, name);
            var toAddress = new MailAddress("euroitex@bih.net.ba", "Euro Itex");
            const string fromPassword = "domino";
            string subject = Request["subject"];
            string body = Request["message"]; ;

            var smtp = new SmtpClient
            {
                Host = "smtp.bih.net.ba",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(toAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body+ "\nPhone: " + phone  +"\nCompany: "  +company
                
            })
            {
                smtp.Send(message);
            }
            return RedirectToAction("Index");
        }
    }
}