using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * We are going to build My Gigs page for the artist
 * So the artist can see his upcoming gig
 * 
 * Create Mine() action method in GigsController
 * Add a view for that action method named "Mine.cshtml"
 * Add one more menu "My Upcoming Gigs" to view my gig page and put hyperlink to that page
 * 
 * Currently, when user add a gig, user will be directed to home page
 * Now we will change it to direct to My Upcoming Gigs page
 * On GigsController.Create(), change the .RedirectToAction() to Mine() action method of GigsController
 * 
 * Test: login then access the "My Upcoming Gigs" dropdown menu
 * 
 * Look at:
 * • GigsController.cs -> Mine(), Main.cshtml, Create() (POST)
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
