using System.Web.Optimization;

namespace BaseProject.Web
{
    public class ScriptsConfig
    {
        public static string MasterScripts = "~/Bundles/MasterScripts";
        public static string TestScripts = "~/Bundles/TestScripts";

        public static void ConfigureBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(MasterScripts).Include(
                "~/Scripts/ThirdParty/poor-mans-error-logger.js",
                "~/Scripts/ThirdParty/angular-1.5.2/angular.js",
                "~/Scripts/ThirdParty/angular-1.5.2/angular-resource.js",
                "~/Scripts/ThirdParty/angular-1.5.2/angular-sanitize.js"
            ).IncludeDirectory(
                "~/Scripts/Modules", "*.js", true
            ));

            bundles.Add(new ScriptBundle(TestScripts).Include(
                "~/Scripts/ThirdParty/jasmine-2.5.2/jasmine.js",
                "~/Scripts/ThirdParty/jasmine-2.5.2/jasmine-html.js",
                "~/Scripts/ThirdParty/jasmine-2.5.2/boot.js"
                ).IncludeDirectory(
                "~/Scripts/Tests", "*.js"
                ));
        }
    }
}