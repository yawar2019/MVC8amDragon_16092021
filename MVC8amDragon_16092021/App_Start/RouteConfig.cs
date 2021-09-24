using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC8amDragon_16092021
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "new", action = "LuckyNumber", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default124",
                url: "Ameerpet/nareshit",
                defaults: new { controller = "new", action = "LuckyNumber", id = UrlParameter.Optional }
            );
           
        }
    }
}
