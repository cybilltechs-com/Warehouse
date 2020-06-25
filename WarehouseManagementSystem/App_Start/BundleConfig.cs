using System.Web;
using System.Web.Optimization;

namespace WarehouseManagementSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*", 
                        "~/Content/plugins/jquery/jquery-1.11.3.min.js", 
                        "~/Content/plugins/bootstrap/js/bootstrap.min.js",
                        "~/Content/plugins/jquery-ui-1.11.4/jquery-ui.js",
                        "~/Content/plugins/owl.carousel-2/owl.carousel.min.js",
                        "~/Content/plugins/jquery-appear/jquery.appear.js",
                        "~/Content/plugins/jquery-countTo/jquery.countTo.js",
                        "~/Content/plugins/jquery-validation/dist/jquery.validate.min.js",
                        "~/Content/plugins/gmap.js",
                        "~/Content/plugins/jquery.mixitup.min.js",
                        "~/Content/plugins/revolution/js/jquery.themepunch.tools.min.js",
                        "~/Content/plugins/revolution/js/jquery.themepunch.revolution.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.actions.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.carousel.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.kenburn.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.layeranimation.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.migration.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.navigation.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.parallax.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.slideanims.min.js",
                        "~/Content/plugins/revolution/js/extensions/revolution.extension.video.min.js",
                        "~/Content/plugins/fancyapps-fancyBox/source/jquery.fancybox.pack.js",
                        "~/Content/plugins/fancyapps-fancyBox/source/jquery.fancybox.pack.js",
                        "~/Content/plugins/typed.js-master/dist/typed.min.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                    "~/Content/plugins/fancyapps-fancyBox/source/jquery.fancybox.css",
                    "~/Content/plugins/animate.min.css", 
                    "~/Content/plugins/owl.carousel-2/assets/owl.theme.default.min.css",
                    "~/Content/plugins/owl.carousel-2/assets/owl.carousel.css", 
                    "~/Content/plugins/jquery-ui-1.11.4/jquery-ui.css", 
                    "~/Content/plugins/flaticon/flaticon.css", 
                    "~/Content/plugins/revolution/css/navigation.css", 
                    "~/Content/plugins/revolution/css/layers.css", 
                    "~/Content/plugins/revolution/css/settings.css", 
                    "~/Content/plugins/Stroke-Gap-Icons-Webfont/style.css",
                    "~/Content/plugins/font-awesome/css/font-awesome.min.css",
                    "~/Content/plugins/bootstrap/css/bootstrap.min.css",
                    "~/Content/css/style.css",
                    "~/Content/css/responsive.css"
                    ));
        }
    }
}
