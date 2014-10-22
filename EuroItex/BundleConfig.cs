using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace EuroItex
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/font-awesome.css",
                "~/Content/animate.min.css",
                "~/Content/prettyPhoto.css",
                "~/Content/main.css",
                "~/Content/reponsive.css"

                ));
            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
              "~/Scripts/jquery.js",
              "~/Scripts/bootstrap.min.js",
              "~/Scripts/jquery.prettyPhoto.js",
              "~/Scripts/jquery.isotope.min.js",
              "~/Scripts/main.js",
              "~/Scripts/wow.min.js"
                ));
        }
    }
}