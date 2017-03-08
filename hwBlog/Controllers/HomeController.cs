using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hwBlog.Controllers
{
	[RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is my About Me Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome to My contact page.";

            return View();
        }
    }
}