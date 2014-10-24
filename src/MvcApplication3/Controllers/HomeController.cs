using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        private static readonly Random _random = new Random();

        public ActionResult Ajax()
        {
            var startTime = DateTime.Now;
            //Thread.Sleep(_random.Next(5000, 10000));
            return Json(new
            {
                startTime = startTime.ToString("HH:mm:ss fff"),
                endTime = DateTime.Now.ToString("HH:mm:ss fff")
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetList()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(15 * 1000);
            return Json(new
            {
                startTime = startTime.ToString("HH:mm:ss fff"),
                endTime = DateTime.Now.ToString("HH:mm:ss fff")
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewInIframe()
        {
            return View();
        }
    }
}