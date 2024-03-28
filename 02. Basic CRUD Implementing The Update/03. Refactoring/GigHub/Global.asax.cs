using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * Rename the Create.cshtml from GigsController into GigForm.cshtml
 * Change the view referencing to GigForm view in GigController
 * which are in Edit() and Create()
 * 
 * In the heading and title of GigForm.cshtml, we will make it dynamic by addding Heading property in GigFormVM
 * Then on both action method mentioned above we put the heading string on that Heading property of view model object
 * 
 * Look at:
 * • GigsController.cs -> Create.cshtml (renamed), GigForm.cshtml, Edit(), Create()
 * • GigFormVM.cs
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
