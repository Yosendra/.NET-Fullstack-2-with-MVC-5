using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * When we cancel a gig, then we refresh the my upcoming gig page.
 * The deleted gig is still there. We will exclude the canceled gig in the gigs query.
 * 
 * In GigsController.Mine() add the condition in LINQ query to get only the IsCanceled gig is false only
 * Also in HomeController.Index()
 * 
 * Look at:
 * • GigsController.cs -> Mine()
 * • HomeController.cs -> Index()
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
