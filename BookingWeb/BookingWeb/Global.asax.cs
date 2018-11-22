using BookingWeb.App_Start;
using Ninject;
using Ninject.Web.Mvc;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BookingWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var ninject = new NinjectBinding();
            var kernel = new StandardKernel(ninject);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}

//TODO: 1. Додати можливість створення/редагування/видалення поїзда
