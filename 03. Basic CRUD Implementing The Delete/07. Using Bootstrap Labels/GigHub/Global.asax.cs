using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * If I already add a gig from another artist.
 * Then i can see it in the Gig I'm Going page.
 * What happen if the artist canceled his gig which alredy add to our calendar?
 * We don't want to not display the in our calendar, instead we still keep it appear
 * but will labeled it as cenceled.
 * 
 * Modify Gig.cshtml which used by GigsController.Attending() to display Gig in our calendar
 * Give the label canceled next to gig name and also hide the going button if gig is canceled
 * 
 * Look at:
 * • Gigs.cshtml
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
