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
 * For rendering the notification we will use a concept named template engine
 * It same like how we consume our API. We got data in json format then based on tempelate format we defined
 * render the view using its json data and template format.
 * 
 * Here we use underscore.js library. (https://underscorejs.org/)
 * We download the script from here: https://github.com/jashkenas/underscore
 * (notice we do not use the esm or umd build, just plain underscore-min.js)
 * Put the script under Scripts folder, and add it to the bundle in BundleConfig
 * In _Layout.cshtml put the logic for notification popover using underscore object
 * 
 * Test: click on notification icon
 * 
 * Look at:
 * • BundleConfig.cshtml
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
