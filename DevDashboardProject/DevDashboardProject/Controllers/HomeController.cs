using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevDashboardProject.Models;

namespace DevDashboardProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DashboardViewModel vm = new DashboardViewModel();
            return View(vm);
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