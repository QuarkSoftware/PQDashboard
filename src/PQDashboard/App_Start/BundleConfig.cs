﻿using System.Web;
using System.Web.Optimization;

namespace PQDashboard
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new StyleBundle("~/css.bundle/site").Include(
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/Scripts/default").Include(
                "~/Scripts/site.js",
                "~/Scripts/default.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                "~/Scripts/jquery-2.1.1.js",
                "~/Scripts/jquery-ui.js",
                "~/Scripts/jquery.signalR-2.2.0.js",
                "~/Scripts/jquery.blockUI.js",
                "~/Scripts/jquery.sparkline.js",
                "~/Scripts/jquery.multiselect.js",
                "~/Scripts/jquery.multiselect.filter.js",
                "~/Scripts/jstorage.js",
                "~/Scripts/jquery.jspanel-compiled.min.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/D3/d3").Include(
                "~/Scripts/D3/d3.js",
                "~/Scripts/D3/d3-color.v1.js",
                "~/Scripts/D3/d3-interpolate.v1.js",
                "~/Scripts/D3/d3-scale.v1.js",
                "~/Scripts/D3/d3-shape.v1.js"
            ));

            bundles.Add(new ScriptBundle("~/Scripts/flot/flot").Include(
                "~/Scripts/flot/jquery.flot.js",
                "~/Scripts/flot/jquery.flot.errorbars.js",
                "~/Scripts/flot/jquery.flot.navigate.js",
                "~/Scripts/flot/jquery.flot.resize.js",
                "~/Scripts/flot/jquery.flot.time.js",
                "~/Scripts/flot/jquery.flot.selection.js"
            ));

            bundles.Add(new StyleBundle("~/Content/default").Include(
                "~/Content/Default.css"
            ));

            // Code removed for clarity.
            BundleTable.EnableOptimizations = true;


        }
    }
}
