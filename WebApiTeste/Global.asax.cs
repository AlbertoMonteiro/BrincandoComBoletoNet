using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiTeste
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            RouteTable.Routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "main", action = "index", id = RouteParameter.Optional});
        }
    }
}
