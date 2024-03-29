using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Using Factory Methods to Create Objects
 * 
 * Issue: when updating Gig we use line like this at Gig.Modify():
        var notification = new Notification(NotificationType.GigUpdated, this)
        {
            OriginalVenue = Venue,
            OriginalDateTime = DateTime,
        };
 * It is possible we forget to assign OriginalVenue and OriginalDateTime
 * We use Factory Methods to solve this
 * Just watch, many steps...
 * 
 * Look at:
 * • Notification.cs -> Constructor, GigCreated(), GigUpdated(), GigCanceled()
 * • Gig.cs -> Modify(), Cancel()
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
