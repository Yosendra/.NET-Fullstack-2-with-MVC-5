using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using GigHub.App_Start;

/* Password : User1#123
 * user1@domain.com
 * yosi@domain.com
 * artist1@domain.com
 * artist2@domain.com
 * 
 * Create a class named "MappingProfile" under App_Start folder inherit to Profile class
 * The mapping profile we write at NotificationsController.GetNotifications(),
 * we move them to this MappingProfile class
 * In the Global.asax.cs we register the MappingProfile class
 * 
 * Look at:
 * • NotificationsController.cs (API) -> GetNotifications()
 * • MappingProfile.cs
 * • Global.asax.cs
*/

namespace GigHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());             // register the MappingProfile
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
