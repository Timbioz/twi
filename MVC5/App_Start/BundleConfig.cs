using System.Web;
using System.Web.Optimization;

namespace MVC5
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var jqueryCdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js";
            var bootstrapCssCdnPath = "http://netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css";
            var bootstrapThemeCssCdnPath = "http://netdna.bootstrapcdn.com/bootstrap/3.0.0/bootstrap-theme.min.css";
            var bootstrapJsCdnPath = "http://netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js";




            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-theme.css"));
        }
    }
}
