﻿using System.Web;
using System.Web.Optimization;

namespace ZerowasteRecipe
{
    public class BundleConfig
    {
        

            public static void RegisterBundles(BundleCollection bundles)
            {
                bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/Scripts/jquery-{version}.js",
                            "~/Scripts/moment.js"
                            ));

                bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                            "~/Scripts/jquery.validate*"));


                bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));

                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                          "~/Scripts/bootstrap.js",

                          "~/Scripts/repond.js",

                          "~/Scripts/bootstrap-datetimepicker.js"));

                bundles.Add(new StyleBundle("~/Content/css").Include(
                          "~/Content/bootstrap.css",
                          "~/Content/site.css",
                          "~/Content/bootstrap-Datetimepicker.css"));
            }
        
    }
}