using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Password : User1#123
 * user1@domain.com
 * yosi@domain.com
 * artist1@domain.com
 * artist2@domain.com
 * 
 * Install "AutoMapper (4.1.1)" package from Nuget Package Manager
 * Look at NotificationsController.GetNotifications()
 * We use automapper function to mapping domain object into dto object
 * Look at the comparison between using manual and using automapper
 * 
 * Test: Test the same like before, to make sure it working properly
 * 
 * Look at:
 * • NotificationsController.cs (API) -> GetNotifications()
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
