using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * When we click cancel link in My Upcoming Gig, there appear plain javascript alert asking for confirmation.
 * We will use bootstrap modal, that will give our application a more modern look and feel.
 * We will use javascript library called "Bootbox" (https://bootboxjs.com/)
 * 

Bootbox.js is a small JavaScript library which allows you to create custom modal dialogs using Bootstrap modals, 
without having to worry about creating, managing, or removing any of the required DOM elements or JavaScript event handlers.

 * Bootbox is basically a library built on top of Bootstrap, which make it easy to use Bootstrap modals.
 * You write less code to achieve the same thing.
 * 
 * In our time using this library, we download the bootbox javascript at this url: 
 * download: https://github.com/makeusabrew/bootbox/releases/download/v6.0.0/bootbox.all.min.js (Bootbox v6.0.0)
 * cdnjs:    https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/6.0.0/bootbox.all.min.js (Bootbox v6.0.0)
 * 
 * Put the file under Scripts folder. The file name is "bootbox.all.min.js"
 * Include that file to the bundle scripts in BundleConfig
 * 
 * Now in Mine.cshtml, put the bootbox logic replacing our confirm() logic
 * 
 * Test: Cancel the gig. There will appear bootstrap modal with modern look & feel
 * 
 * Look at:
 * • bootbox.all.min.js
 * • BundleConfig.cs
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
