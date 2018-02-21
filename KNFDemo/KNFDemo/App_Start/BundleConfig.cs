using System.Web;
using System.Web.Optimization;

namespace KNFDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

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
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));




            #region [Theme Styles]

            #region [BEGIN GLOBAL MANDATORY STYLES]

            // < !--BEGIN GLOBAL MANDATORY STYLES-- >
            // <link href="../assets/global/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
            // <link href="../assets/global/plugins/simple-line-icons/simple-line-icons.min.css" rel="stylesheet" type="text/css" />
            // <link href="../assets/global/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
            // <link href="../assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css" rel="stylesheet" type="text/css" />
            // < !--END GLOBAL MANDATORY STYLES-- >

            bundles.Add(new StyleBundle("~/Metronic/begin_global_mandatory_styles").Include(
                "~/assets/global/plugins/font-awesome/css/font-awesome.css",
                "~/assets/global/plugins/simple-line-icons/simple-line-icons.css",
                "~/assets/global/plugins/bootstrap/css/bootstrap.css",
                "~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.css"
                ));

            #endregion

            #region [BEGIN THEME GLOBAL STYLES]

            // <!-- BEGIN THEME GLOBAL STYLES -->
            // <link href="../assets/global/css/components-md.min.css" rel="stylesheet" id="style_components" type="text/css" />
            // <link href="../assets/global/css/plugins-md.min.css" rel="stylesheet" type="text/css" />
            // <!-- END THEME GLOBAL STYLES -->

            bundles.Add(new StyleBundle("~/Metronic/begin_theme_global_styles").Include(
                "~/assets/global/css/components.css",
                "~/assets/global/css/plugins.css"
                ));

            #endregion

            #endregion

            #region [Theme Scripts]

            #region [BEGIN THEME LAYOUT STYLES]

            // <!-- BEGIN THEME LAYOUT STYLES -->
            // <link href="../assets/layouts/layout3/css/layout.min.css" rel="stylesheet" type="text/css" />
            // <link href="../assets/layouts/layout3/css/themes/default.min.css" rel="stylesheet" type="text/css" id="style_color" />
            // <link href="../assets/layouts/layout3/css/custom.min.css" rel="stylesheet" type="text/css" />
            // <!-- END THEME LAYOUT STYLES -->
            bundles.Add(new StyleBundle("~/Metronic/begin_theme_layout_styles").Include(
                "~/assets/layouts/layout3/css/layout.css",
                "~/assets/layouts/layout3/css/themes/default.css",
                "~/assets/layouts/layout3/css/custom.css"
                ));

            #endregion
                      
            #region [BEGIN CORE PLUGINS]

            // <!-- BEGIN CORE PLUGINS -->
            // <script src="../assets/global/plugins/jquery.min.js" type="text/javascript"></script>
            // <script src="../assets/global/plugins/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
            // <script src="../assets/global/plugins/js.cookie.min.js" type="text/javascript"></script>
            // <script src="../assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js" type="text/javascript"></script>
            // <script src="../assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js" type="text/javascript"></script>
            // <script src="../assets/global/plugins/jquery.blockui.min.js" type="text/javascript"></script>
            // <script src="../assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js" type="text/javascript"></script>
            // <!-- END CORE PLUGINS -->

            bundles.Add(new ScriptBundle("~/Metronic/begin_core_plugins").Include(
                "~/assets/global/plugins/jquery.js",
                "~/assets/global/plugins/bootstrap/js/bootstrap.js",
                "~/assets/global/plugins/js.cookie.js",
                "~/assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.js",
                "~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.js",
                "~/assets/global/plugins/jquery.blockui.js",
                "~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.js"
                ));

            #endregion

            #region [BEGIN THEME GLOBAL SCRIPTS]

            //<!-- BEGIN THEME GLOBAL SCRIPTS -->
            //<script src="../assets/global/scripts/app.min.js" type="text/javascript"></script>
            //<!-- END THEME GLOBAL SCRIPTS -->

            bundles.Add(new ScriptBundle("~/Metronic/begin_theme_global_scripts").Include(
                "~/assets/global/scripts/app.js"
                ));

            #endregion

            #region [BEGIN THEME LAYOUT SCRIPTS]

            //<!-- BEGIN THEME LAYOUT SCRIPTS -->
            //<script src="../assets/layouts/layout3/scripts/layout.min.js" type="text/javascript"></script>
            //<script src="../assets/layouts/layout3/scripts/demo.min.js" type="text/javascript"></script>
            //<script src="../assets/layouts/global/scripts/quick-sidebar.min.js" type="text/javascript"></script>
            //<!-- END THEME LAYOUT SCRIPTS -->

            bundles.Add(new ScriptBundle("~/Metronic/begin_theme_layout_scripts").Include(
                "~/assets/layouts/layout3/scripts/layout.js",
                "~/assets/layouts/layout3/scripts/demo.js",
                "~/assets/layouts/global/scripts/quick-sidebar.js"
                ));

            #endregion
            
            #endregion
        }
    }
}
