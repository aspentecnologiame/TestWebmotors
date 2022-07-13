using System.Web;
using System.Web.Optimization;

namespace MarcosCosta.Front
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //SCRIPTS

            //Jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //AdminLTE
            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                       "~/Scripts/adminlte.min.js"));

            //Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.bundle.min.js"));

            //Angular
            bundles.Add(new ScriptBundle("~/bundles/angularJS").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js",
                        "~/Scripts/angular-touch.min.js",
                        "~/Scripts/angular-animate.min.js",
                        "~/Scripts/angular-aria.min.js",
                        "~/Scripts/angular-resource.min.js",
                        "~/Scripts/angular-sanitize.min.js",
                        "~/Scripts/angular-cookies.min.js"));

            //Angular UI
            bundles.Add(new ScriptBundle("~/bundles/angularUI").Include(
                        "~/Scripts/angular-ui/ui-bootstrap.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                        "~/Scripts/angular-ui/ui-mask.min.js",
                        "~/Scripts/colorpicker/bootstrap-colorpicker-module.js"));

            //Globals
            bundles.Add(new ScriptBundle("~/bundles/globals").Include(
                        "~/app/globals/global.js"));

            //APP
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/app/modules/app.js"));

            //Controllers
            bundles.Add(new ScriptBundle("~/bundles/controllers").Include(
                        "~/app/controllers/layoutController.js",
                        "~/app/controllers/indexController.js"));

            //Directives
            bundles.Add(new ScriptBundle("~/bundles/directives").Include(
                        "~/app/directives/directiveSelect.js",
                        "~/app/directives/directiveFormatNumber.js"));

            //Factories
            bundles.Add(new ScriptBundle("~/bundles/factories").Include(
                        "~/app/factories/indexFactory.js"));

            //Services
            bundles.Add(new ScriptBundle("~/bundles/services").Include(
                        "~/app/services/indexService.js",
                        "~/app/services/localStorageService.js",
                        "~/app/services/layoutService.js",
                        "~/app/services/searchZipCodeService.js"));

            //Filters
            bundles.Add(new ScriptBundle("~/bundles/filters").Include(
                        "~/app/filters/brlCurrencyFilter.js"));

            //Modal
            bundles.Add(new ScriptBundle("~/bundles/modal").Include(
                        "~/app/modal/confirmController.js"));

            //CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/adminlte.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/ui-bootstrap-csp.css",
                      "~/Content/select2-3.4.5.css",
                      "~/Content/selectize.default-0.8.5.css",
                      "~/Content/ui-select-0.19.7.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/lib/fontawesome").Include(
                      "~/lib/font-awesome/css/all.min.css"));

            //UI-Grid
            bundles.Add(new StyleBundle("~/lib/ui-grid").Include(
                      "~/lib/ui-grid/ui-grid-4.10.0.css"));

            bundles.Add(new ScriptBundle("~/bundles/ui-grid").Include(
                        "~/lib/ui-grid/ui-grid-4.10.0.js"));

            //RM-Datapicker
            bundles.Add(new StyleBundle("~/lib/rm-datepicker").Include(
                      "~/lib/rm-datepicker/rm-datepicker.css"));

            bundles.Add(new ScriptBundle("~/bundles/rm-datepicker").Include(
                        "~/lib/rm-datepicker/rm-datepicker.js"));

            //UI-Select
            bundles.Add(new ScriptBundle("~/bundles/ui-select").Include(
                      "~/Scripts/ui-select-0.19.7.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
