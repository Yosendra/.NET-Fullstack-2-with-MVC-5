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
 * We want to remove the padding in the popover, like that so the border will full to the container at right and left side
 * Need to read the documentation for Popover bootstrap component, look at option template:
 * Detail: https://getbootstrap.com/docs/5.3/components/popovers/#options
 * Add template options for .popover() at _Layout.cshtml
 * Then add our styling for that popover notification in Site.css
 * 
 * Test: login as artist 2, click on notification icon
 * 
 * Look at:
 * • _Layout.cshtml
 * • Site.css
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
