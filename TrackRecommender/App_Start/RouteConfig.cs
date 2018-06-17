using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TrackRecommender
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Genre",
                url: "Genre/{action}",
                defaults: new { controller = "Genre", action = "Genre" }
            );

            routes.MapRoute(
                name: "Tracks",
                url: "Tracks/{action}",
                defaults: new { controller = "Tracks", action = "Tracks" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Genre", action = "Genre", id = UrlParameter.Optional }
            );
        }
    }
}