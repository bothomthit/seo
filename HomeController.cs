using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEO.banmypham.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ProductList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lip()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Eye()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Face()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Skincare()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult beautyblog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Sale() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}