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
 * Add animation effecto on notification badge using css library
 * Animate.css (https://animate.style/)
 * Download the css at https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css
 * Copy-Paste the css file to Content folder
 * Add animate.min.css file to the bundle in Bundle config
 * 
 * In the javascript that handle notification badge at _Layout.cshtml
 * Add certain class to invoke animation
 * 
 * Look at:
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
