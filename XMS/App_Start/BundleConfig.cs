using System.Web;
using System.Web.Optimization;

namespace Thunder.XMS
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region 框架页面
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
            #endregion

            #region 框架内页
            bundles.Add(new ScriptBundle("~/js/page").Include(
                "~/Scripts/page.js",
                "~/Scripts/jquery-3.3.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/bootstrap-datetimepicker.js",
                "~/Scripts/plugins/bootstrap-editable.js",
                "~/Scripts/plugins/bootstrap-table/bootstrap-table.min.js",
                "~/Scripts/plugins/bootstrap-table/bootstrap-table-editable.js",
                "~/Scripts/plugins/bootstrap-table/bootstrap-table-zh-CN.min.js",
                "~/Scripts/plugins/bootstrap-table-treegrid.js",
                "~/Scripts/plugins/jquery.treegrid.min.js",
                "~/Scripts/plugins/bootstrapValidator/bootstrapValidator.min.js"
                ));

            bundles.Add(new ScriptBundle("~/css/page").Include(
                "~/Content/bootstrap.css",
                "~/Content/datetimepicker.css",
                "~/Content/animate.min.css",                
                "~/Content/fonts/font-awesome.min.css",
                "~/Content/plugins/jquery.treegrid.min.css",
                "~/Content/plugins/bootstrap-table/bootstrap-table.min.css",
                "~/Content/plugins/bootstrapValidator/bootstrapValidator.min.css",
                "~/Content/plugins/bootstrap-editable.css"
                ));
            #endregion
        }
    }
}
