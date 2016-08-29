using System.Web.Mvc;
using System.Web.Routing;

namespace SkateOne.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "API",
                "api/{controller}/{action}/{id}",
                new { controller = "Skate", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                "Default",
                "{*catchall}",
                new { controller = "Skate", action = "Index" }
            );
        }
    }
}