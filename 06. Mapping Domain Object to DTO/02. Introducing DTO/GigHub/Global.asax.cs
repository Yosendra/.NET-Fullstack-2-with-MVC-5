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
 * In NotificationsController.GetNotifications(), we change the return type into "IEnumerable<Notification>" (we will do it later)
 * Now we create NotificationDto class in Dtos folder
 * First we copy all properties from Notification domain class to the NotificationDto class
 * Then we exclude any properties if it is not needed to be exposed
 * Create GigDto, UserDto, GenreDto class. The same process we do like NotificationDto for these dto classes
 * 
 * Look at:
 * • NotificationDto.cs
 * • GigDto.cs
 * • UserDto.cs
 * • GenreDto.cs
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
