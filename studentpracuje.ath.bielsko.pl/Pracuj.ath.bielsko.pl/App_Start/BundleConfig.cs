using System.Web;
using System.Web.Optimization;

namespace Pracuj.ath.bielsko.pl
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                        .Include("~/Scripts/jquery.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/customscripts").Include(
                        "~/Scripts/registerscripts.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                     "~/Scripts/moment.min.js",
                        "~/Scripts/nouislider.min.js",
                        "~/Scripts/now-ui-kit.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/bootstrap-switch.js",
                        "~/Scripts/tether.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/offerts_management.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Styles.css",
                      "~/Content/now-ui-kit.css"));
        }
    }
}
