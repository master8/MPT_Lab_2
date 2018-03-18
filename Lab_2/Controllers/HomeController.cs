using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_2.Controllers
{
    public class HomeController : Controller
    {
        [Import(typeof(ILogger))]
        public ILogger Logger { get; set; }

        public HomeController()
        {
            MvcApplication.container.ComposeParts(this);
        }

        public ActionResult Index()
        {
            Logger.Log("Hello, world =)");
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
    }
}