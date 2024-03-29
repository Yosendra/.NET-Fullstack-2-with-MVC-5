using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* Password : User1#123
 * user1@domain.com
 * yosi@domain.com
 * 
 * artist1@domain.com
 * artist2@domain.com
 * 
 * Building an API
 * 
 * GET  /api/notifications
 * 
 * Create API controller named "NotificationsController" under Conrollers/Api folder
 * Create action method GetNotifications()
 * 
 * Test: Artist 1 make a gig,
 *       Artist 2 going to the gig created by Artist 1,
 *       Artist 1 cancel his gig,
 *       Artist 2 log in, check through postman by hitting "GET  /api/notifications"
 * 
 * With the query you write in NotificationsController.GetNotifications(), you will get result like this:
[
    {
        "Id": 1,
        "DateTime": "2024-03-29T18:13:32.02",
        "Type": 1,
        "OriginalDateTime": null,
        "OriginalVenue": null,
        "GigId": 12,
        "Gig": {
            "Id": 12,
            "Artist": {
                "Claims": [],
                "Logins": [],
                "Roles": [],
                "Name": "Artist 1",
                "Followers": [],
                "Followees": null,
                "UserNotifications": [],
                "Email": "artist1@domain.com",
                "EmailConfirmed": false,
                "PasswordHash": "AJbmQxZ76ENzAu2rQxUUZ6VNg63vEej51xEJNb1m51/mttqGmlkToDxCuh+ZM9rDsQ==",
                "SecurityStamp": "b4104c63-0e6e-461e-8238-9ac091342d02",
                "PhoneNumber": null,
                "PhoneNumberConfirmed": false,
                "TwoFactorEnabled": false,
                "LockoutEndDateUtc": null,
                "LockoutEnabled": true,
                "AccessFailedCount": 0,
                "Id": "f8c5a232-de66-44f9-86a0-2bcee0ebb788",
                "UserName": "artist1@domain.com"
            },
            "ArtistId": "f8c5a232-de66-44f9-86a0-2bcee0ebb788",
            "DateTime": "2040-11-20T20:00:00",
            "Venue": "Jakarta Convention Center",
            "Genre": null,
            "GenreId": 1,
            "IsCanceled": true,
            "Attendances": []
        }
    }
]
 * Look at the Artist line 36, many sensitive information get exposed to the user
 * That's where we use dto class instead of domain class when returning data to the client
 * Best practice: We should not expose domain object from our API because domain objects
 *                are the internal for application. Instead we should return DTO.
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
