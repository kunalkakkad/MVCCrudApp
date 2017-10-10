using System.Web;
using System.Web.Optimization;

namespace MVC_Sumeet_Crud
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/plugins/jQuery/jquery-1.12.4.min.js",
                "~/Content/plugins/jquery-ui-1.12.1/jquery-ui.min.js",
                "~/Content/bootstrap/js/bootstrap.min.js",
                "~/Content/plugins/lobipanel/lobipanel.min.js",
                "~/Content/plugins/pace/pace.min.js",
                "~/Content/plugins/table-export/tableExport.js",
                "~/Content/plugins/table-export/jquery.base64.js",
                "~/Content/plugins/table-export/html2canvas.js",
                "~/Content/plugins/table-export/sprintf.js",
                "~/Content/plugins/table-export/jspdf.js",
                "~/Content/plugins/table-export/base64.js",
                "~/Content/plugins/datatables/dataTables.min.js",
                "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                "~/Content/plugins/fastclick/fastclick.min.js",
                "~/Content/dist/js/custom.js",
                "~/Content/dist/js/dashboard.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/plugins/jquery-ui-1.12.1/jquery-ui.min.css",
                "~/Content/bootstrap/css/bootstrap.min.css",
                "~/Content/plugins/lobipanel/lobipanel.min.css",
                "~/Content/plugins/pace/flash.css",
                "~/Content/font-awesome/css/font-awesome.min.css",
                "~/Content/pe-icon-7-stroke/css/pe-icon-7-stroke.css",
                "~/Content/themify-icons/themify-icons.css",
                "~/Content/plugins/datatables/dataTables.min.css",
                "~/Content/dist/css/stylecrm.css"));
        }
    }
}
