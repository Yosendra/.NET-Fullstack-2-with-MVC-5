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
 * Add new endpoing Search() for search gigs via query string parameter in GigsController
 * In HomeController.Index(), add new parameter to catch the query string
 * also add the logic for filtering gigs if query is not null
 * 
 * Test: Homepage, look at the search gigs input above the gig list
 * 
 * Look at:
 * • Gigs.cshtml
 * • GigsController.cs -> Search()
 * • HomeController.cs -> Index()
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
