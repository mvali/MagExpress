using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagExpress.Controllers
{
    public class ArchiveController : Controller
    {
        // GET: Archive
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Layout1()
        {
            return View();
        }
        public ActionResult Layout2()
        {
            return View();
        }
        public ActionResult Layout3()
        {
            return View();
        }
        public ActionResult Layout4()
        {
            return View();
        }
        public ActionResult BlogArchive()
        {
            return PartialView();
        }
        public ActionResult PopularLinks()
        {
            return PartialView();
        }
    }
}