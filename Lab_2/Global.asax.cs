using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Lab_2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static CompositionContainer container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(".", "*.exe"));
            container = new CompositionContainer(catalog);
        }
    }
}
