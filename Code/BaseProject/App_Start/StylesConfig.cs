using System.Web.Optimization;

namespace BaseProject.Web
{
    public class StylesConfig
    {
        public static string ThirdPartyStyles = "~/Bundles/ThirdPartyStyles";
        public static string MasterStyles = "~/Bundles/MasterStyles";

        public static void ConfigureBundles(BundleCollection bundles)
        {
            bundles.Add(new LessBundle(ThirdPartyStyles).Include(
                "~/Styles/ThirdParty/bootstrap-3.3.1/bootstrap.less"
            ));

            bundles.Add(new LessBundle(MasterStyles)
                .IncludeDirectory("~/Styles/Modules", "*.css")
                .IncludeDirectory("~/Styles/Components", "*.css")
                .IncludeDirectory("~/Styles/Templates", "*.css"));
        }
    }
}