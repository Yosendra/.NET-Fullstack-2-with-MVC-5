using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We want to add hyperlink to Edit text we have added before
 * The direct to Gig form edit
 * 
 * Add Edit() action method in GigsController
 * Choose Create.cshtml as its view
 * Add hyperlink a the Edit hyperlink
 * 
 * Test: run the app, click on Edit hyperlink, you will be directed to Edit gigs form page
 * 
 * Look at:
 * • GigsController.cs -> Edit(), Mine.cshtml
*/

namespace GigHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
