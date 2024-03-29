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
 * Documentation : https://icons.getbootstrap.com/
 * We download the css file for this icon at this link:
 * https://github.com/twbs/icons/releases/tag/v1.11.3
 * 
 * In zip file we extract only bootstrap-icons.min.css file & folder named "fonts"
 * We put them inside "Content/bootstrap-icons-1.11.3" folder
 * Now register "bootstrap-icons.min.css" to the bundle in BundleConfig
 * In _LoginPartial.cshtml, we add globe icon next to the dropdown menu, and add some styling for the globe in Site.css
 * 
 * Look at:
 * • BundleConfig.cs
 * • _LoginPartial.cshtml
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
