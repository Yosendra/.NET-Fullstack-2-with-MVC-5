using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Add DbSet property in ApplicationDbContext for the new model class we have created
 * Add migration, then update database
 * You will face error when trying update database due to multiple cascade path
 * To solve this, use FluentAPI to add configuration for disabling cascade in on of the foreign key
 * 
 * After adding the configuration through fluentAPI, then add migration again with force switch
 *   Add-Migration AddNotification -force
 *   Update-Database
 *   
 * Look at:
 * • ApplicationDbContext.cs
 * • 202403282155066_AddNotification.cs
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
