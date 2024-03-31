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
 * We will formatting our datetime in notification so it can be easily red by human
 * we will need a library called Moment.js (2.30.1)
 * Detail: https://momentjs.com/ [or] install through Nuget Package Manager (we use this)
 * After download moment.js, move it to Scripts folder
 * Register it to the bundle in BundleConfig
 * 
 * In _Layout.cshtml, we use the momentjs for formating the date
 * 
 * Test: login as artist 2, click on notification icon, look at the datetime format, more readable than before which use ISO format
 * 
 * Look at:
 * • moment.min.js
 * • BundleConfig.cs
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
