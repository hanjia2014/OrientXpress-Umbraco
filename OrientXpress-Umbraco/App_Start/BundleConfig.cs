using System.Web.Optimization;

namespace OrientXpress.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jquerychocolat").Include(
                        "~/Scripts/jquery.chocolat.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/ox-app").Include(
                      "~/config.js",
                      "~/systemjs.config.js"));

            bundles.Add(new ScriptBundle("~/bundles/sitejs").Include(
                "~/Scripts/site/jquery-1.11.0.min.js",
                "~/Scripts/site/jquery.chocolat.js",
                "~/Scripts/site/easing.js",
                "~/Scripts/site/move-top.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/chocolat.css",
                      "~/Content/style.css",
                      "~/Content/chocolat.css"));


        }
    }
}
