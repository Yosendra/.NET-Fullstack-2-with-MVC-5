using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Creating the UI for Cancel feature in GigsController API consumer.
 * In Mine.cshtml, create Cancel hyperlink next to Edit hyperlink
 * 
 * Add javascript code the bottom page of Mine.cshtml
 * 
 * Test: Cancel the gig in my upcoming gig, the gig will be removed from page
 * 
 * Look at:
 * • Mine.cshtml
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
