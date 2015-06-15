
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CA1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }

        // returns a View with more info about my CA1 ASP.NET project
        public ActionResult About()
        {
            return View();
        }



    }
}
