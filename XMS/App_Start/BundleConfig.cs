using System.Web;
using System.Web.Optimization;

namespace XMS
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/index").Include(
                "~/Scripts/app.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jQuery-2.2.0.min.js",
                "~/Scripts/jquery.nicescroll.min.js",
                "~/Scripts/index.js"));

            bundles.Add(new ScriptBundle("~/css/index").Include(
                "~/Content/AdminLTE.min.css",
                "~/Content/bootstrap.min.css",
                "~/Content/fonts/font-awesome.min.css",
                "~/Content/skin-blue.min.css"));       
        }
    }
}
