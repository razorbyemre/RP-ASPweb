using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BLL;
using BLL.Util;
using Ninject;
using Ninject.Web.Mvc;
using RP_ASPweb.Ninject;
namespace RP_ASPweb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var kernel = new StandardKernel(new NinjectRegister(), new ServiceModule("MonitorContext"));
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
