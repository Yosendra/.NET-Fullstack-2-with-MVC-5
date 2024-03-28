using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * To implement delete operation, we are going to use the mechanism similar to what we did
 * when implementing follow an artist or attend a gig.
 * 
 * In my upcoming gig, we add Cancel hyperlink next to Edit hyperlink.
 * When the user click that, it will call the server using ajax because we don't want
 * to use full page reload. So we need an api to receive the call from ajax.
 * 
 * Create GigsController (Api) in "Controller/Api" folder. Use [Authorize] on that controller.
 * Create action method for canceling gig Cancel()
 * 
 * Test: run the applicaiton hit this "DELETE api/gigs" endpoint using postman extension
 *       then check the data Gigs table at the IsCanceled column, is the value change to true or not
 * 
 * Look at:
 * • GigsController.cs (API) -> Cancel()
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
