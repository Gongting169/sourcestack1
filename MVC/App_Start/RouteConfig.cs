using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "LogOn",
             url: "{Log}/{id}",
             defaults: new { controller = "Log", action = "On", id = UrlParameter.Optional }
         );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "RegisterHome",
             url: "{Register}/{id}",
             defaults: new { controller = "Register", action = "Home", id = UrlParameter.Optional }
         );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "MoneyTradeSale",
             url: "{MoneyTrade}/{id}",
             defaults: new { controller = "MoneyTrade", action = "Sale", id = UrlParameter.Optional }
         );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "PlanNew",
             url: "{Plan}/{id}",
             defaults: new { controller = "Plan", action = "New", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
