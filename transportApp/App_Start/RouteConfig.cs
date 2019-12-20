using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace transportApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Eventübersicht", action = "eventübersicht" }
            );
            routes.MapRoute(
                name: "Eventinfo",
                url: "{controller}/{action}",
                defaults: new { controller = "Eventinfo", action = "eventinfo" }
            );
			routes.MapRoute(
				name: "Login",
				url: "{controller}/{action}",
				defaults: new { controller = "Login", action = "login" }
			);
            routes.MapRoute(
                name: "Autoübersicht",
                url: "{controller}/{action}",
                defaults: new { controller = "Autoübersicht", action = "autoübersicht" }
            );
            routes.MapRoute(
                name: "Auto anmelden",
                url: "{controller}/{action}",
                defaults: new { controller = "Autoanmelden", action = "autoanmelden" }
             );
        }
    }
}
