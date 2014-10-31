using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EuroItex.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangeCulture(string lang, string returnUrl)

     {

          Session["Culture"] = new CultureInfo(lang);

          return Redirect(returnUrl);

       }

    }
}