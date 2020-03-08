using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagExpress.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        {
            return PartialView();
        }
        public ActionResult RecentPosts()
        {
            return PartialView();
        }
        public ActionResult MostPopular()
        {
            return PartialView();
        }
        public ActionResult RecentComments()
        {
            return PartialView();
        }
    }
}