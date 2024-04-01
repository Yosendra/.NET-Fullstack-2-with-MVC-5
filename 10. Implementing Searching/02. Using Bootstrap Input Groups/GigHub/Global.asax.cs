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
 * Implement input group for our Search Gig form
 * Look at the bootstrap documentation for input group here:
 * https://getbootstrap.com/docs/5.3/forms/input-group/
 * 
 * Look at Gigs.cshtml, on search form, we use input group class there based on bootstrap documentation input group
 * 
 * Test: Homepage, look at the search gigs input above the gig list
 * 
 * Look at:
 * • Gigs.cshtml
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
