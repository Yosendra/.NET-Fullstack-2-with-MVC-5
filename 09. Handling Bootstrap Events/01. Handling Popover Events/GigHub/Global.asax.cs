using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;

/* Password : User1#123
 * user1@domain.com
 * yosi@domain.com
 * artist1@domain.com
 * artist2@domain.com
 * 
 * Currently, when we click the notification, the number of amount of notification is still there
 * We want to make it disappear when we click it.
 * Because we use bootstrap popover for notification, we need to read the popover component documentation
 * on event section. Link: https://getbootstrap.com/docs/5.3/components/popovers/#events
 * 
 * Now look at the implementation on _Layout.cshtml, we subscribe the popover event when we click the notification
 * For we just console.log() for the event handling when popover appears
 * 
 * Look at:
 * • _Layout.cshtml
*/

namespace GigHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
