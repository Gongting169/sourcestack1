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
             name: "MoneyTradeSale",
             url: "MoneyTrade/Sale/{id}",
             defaults: new { controller = "MoneyTrade", action = "Sale", id = UrlParameter.Optional }
         );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "PlanNew",
             url: "{controller}/{action}/{id}",
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
