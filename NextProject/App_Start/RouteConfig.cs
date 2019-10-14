using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DataStructures
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Stack",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Stack", action = "Stack", id = UrlParameter.Optional }
              );

            routes.MapRoute(
              name: "Map",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Map", action = "Map", id = UrlParameter.Optional }
              );

            routes.MapRoute(
              name: "Queue",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Queue", action = "Queue", id = UrlParameter.Optional }
              );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
