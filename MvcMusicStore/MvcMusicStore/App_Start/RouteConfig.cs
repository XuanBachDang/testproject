using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMusicStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "id",
                url: "category/{store}/{id}",
                defaults: new { Controller = "Store", action = "Details", id = "" });

            routes.MapRoute(
                name: "default",
                url: "{Controller}/{action}/{id}",
                defaults: new { Controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Browse",
                url: " Store/{browse}/{Genre}",
                defaults: new { Controller = "Sotre", action = "Browse", genre = "" });
            routes.MapRoute(
                name: "Product list of deafault",
                url: "category/store",
                defaults: new {Controller="StoreMangager", Action="Details"}
                );

        }
    }
}
