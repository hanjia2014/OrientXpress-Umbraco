using OrientXpress.App_Start;
using Umbraco.Core;
using System.Web.Optimization;

namespace OrientXpress.App_Code
{
    public class UmbracoEventHandlers : ApplicationEventHandler
    {
        protected override void ApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}