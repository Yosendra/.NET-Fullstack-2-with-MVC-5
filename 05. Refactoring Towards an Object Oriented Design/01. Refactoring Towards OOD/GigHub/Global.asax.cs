using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Refactoring Towards an Object Oriented Design
 * We are trying to refactor our logic in GigsController.Cancel()
 * We use an approach called Rich Domain Class, it means the domain
 * class which has a method. Before our domain class only has data.
 * Now we include method inside it. Just look at the code. It has many steps
 * to take note.
 *   
 * Look at:
 * • GigsController.cs (API) -> Cancel()
 * • ApplicationUser.cs -> Notify
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
