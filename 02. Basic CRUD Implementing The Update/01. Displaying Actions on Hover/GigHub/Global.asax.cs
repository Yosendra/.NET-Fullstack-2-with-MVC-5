using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We are going to implement hiding and show action link (Edit | Delete) when hovering the My Upcoming Gigs item
 * Add hyperlink content "Edit" on Mine.cshtml
 * In Site.css, add styling for that hyperlink content to show when get hovered vice versa
 * 
 * Test: on My Upcoming Gigs page, hover one of Gigs list. Edit hyperlink will when the gig get hovered
 * 
 * Look at:
 * • GigsController.cs -> Mine.cshtml
 * • Site.css
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
