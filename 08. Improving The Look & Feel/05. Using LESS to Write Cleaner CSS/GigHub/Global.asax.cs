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
 * We are trying to use LESS syntax in CSS
 * First, install Web Compiler 2022+ in Extensions -> Manage Extension
 * Rename our Site.css into Site.less
 * Look at Site.less, how we write the css.
 * If you done, compile the Site.less by right click on it Web Compiler -> Compile file / Recompile file
 * Site.css and Site.min.css will be generated.
 * In BundleConfig, change the reference Site.css to Site.min.css or you can keep it to Site.css
 * 
 * Look at:
 * • Site.less
 * • Site.css
 * • Site.min.css
 * • BundleConfig.cs
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
