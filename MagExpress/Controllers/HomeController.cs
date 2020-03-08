using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Top()
        {
            //var items = new Models.Slide().GetList();
            //return PartialView("Slider", items);
            return PartialView("Top");
        }
        public ActionResult Middle()
        {
            return View();
        }
        public ActionResult Bottom()
        {
            return View();
        }
        public ActionResult ErrorPage()
        {
            return View("ErrorPage");
        }

        public ActionResult Base64Encode()
        {
            var qs = Utils.Rq("c");
            var retV = Utils.Base64Encode(qs);
            Log.AddLogEntry("-" + retV);
            return PartialView("Error");
        }
        public ActionResult Base64Decode()
        {
            var qs = Utils.Rq("c");
            var retV = Utils.Base64Decode(qs);
            Log.AddLogEntry("-" + retV);
            return PartialView("Error");
        }
    }
}