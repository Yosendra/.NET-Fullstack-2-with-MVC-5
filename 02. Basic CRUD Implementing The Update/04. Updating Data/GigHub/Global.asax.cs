using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

/* user1@domain.com
 * yosi@domain.com
 * User1#123
 * 
 * In the @Html.BeginForm() syntax at GigForm.cshtml currently it refers to action method GigController.Create()
 * We want to make it dynamic, either it refer to Edit() or Create() using the same technique like we render
 * The page heading
 * 
 * Add Id & Action property in GigFormVM
 * Add hidden input element which contain GigId in GigForm.cshtml, so GigFormVM can accept GigId value
 * 
 * Now we create Edit() (POST) action method in GigsController
 * 
 * Look at:
 * • GigsController.cs -> GigForm.cshtml, Edit(), Create()
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
