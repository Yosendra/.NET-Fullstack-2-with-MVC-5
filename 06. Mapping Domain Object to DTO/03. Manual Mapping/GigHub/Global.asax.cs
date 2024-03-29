using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Password : User1#123
 * user1@domain.com
 * yosi@domain.com
 * artist1@domain.com
 * artist2@domain.com
 * 
 * NotificationsController.GetNotifications() we put the logic to return the Dto object
 * We try to do "manual" mapping from domain object to dto
 * 
 * Test: Login as "Artist 2" hit API to this endpoint "GET /api/notifications"
 * Now the result become like this
[
    {
        "DateTime": "2024-03-29T18:13:32.02",
        "Type": 1,
        "OriginalDateTime": null,
        "OriginalVenue": null,
        "Gig": {
            "Id": 12,
            "Artist": {
                "Id": "f8c5a232-de66-44f9-86a0-2bcee0ebb788",
                "Name": "Artist 1"
            },
            "DateTime": "2040-11-20T20:00:00",
            "Venue": "Jakarta Convention Center",
            "Genre": null,
            "IsCanceled": true
        }
    }
] 
 * We exposed data that suitable to be exposed. We don't expose sensitive data like before.
 *
 * Look at:
 * • NotificationsController.cs (API) -> GetNotifications()
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
