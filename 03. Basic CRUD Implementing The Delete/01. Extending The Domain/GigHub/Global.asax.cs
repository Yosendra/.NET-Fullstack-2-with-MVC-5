using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We are going to implement logical delete
 * Instead of actually delete the data, we will give it a flag to mark it as deleted
 * 
 * This is useful for preventing multiple cascade path problem, also give the ability to user to undo things
 * 
 * In Gig class, add "IsCanceled" property. We choose that name instead of IsDeleted is because we suits
 * our domain. In real-world context, We cancel the gig, not delete the gig.
 * Add migration and update database.
 * 
 * Look at:
 * • Gig.cs
 * • 202403281047177_AddIsCanceledToGig.cs
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
