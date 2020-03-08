using System.Web;
using System.Web.Optimization;

namespace MagExpress
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Assets/Scripts/jquery.{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Assets/Scripts/jquery.min.js",//
                "~/Assets/Scripts/bootstrap.min.js",//
                "~/Assets/Scripts/wow.min.js",
                "~/Assets/Scripts/slick.min.js",
                "~/Assets/Scripts/custom.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Assets/Scripts/jquery.validate*",
                "~/Assets/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/ie9").Include(
                "~/Assets/Scripts/html5shiv.min.js*",
                "~/Assets/Scripts/respond.min.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));


            //bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Assets/Css", "*.css"));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Assets/Css/bootstrap.min.css",
                "~/Assets/Css/font-awesome.min.css",
                "~/Assets/Css/animate.css",
                "~/Assets/Css/slick.css",
                "~/Assets/Css/theme.css",
                "~/Assets/Css/style.css"
                ));
        }
    }
}
