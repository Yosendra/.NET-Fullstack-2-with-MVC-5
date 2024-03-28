using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We will customize our bootbox logic in Mine.cshtml
 * because there are some usability consideration we notice 
 * when the modal appear when clicking the cancel button
 * 
 * To be able to use customize the bootbox modal, use bootbox.dialog() instead
 * (read the documentation at bootbox website for more details)
 * 
 * Look at:
 * • Mine.cshtml
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
