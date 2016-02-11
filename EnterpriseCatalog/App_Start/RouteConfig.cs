using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EnterpriseCatalog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "createEnterprise",
              url: "Enterprise/create",
              defaults: new { controller = "Enterprise", action = "Create"}
          );

            routes.MapRoute(
              name: "about",
              url: "About",
              defaults: new { controller = "Home", action = "About" }
          );

            routes.MapRoute(
              name: "EnterpriseList",
              url: "Enterprsie/List",
              defaults: new { controller = "Enterprise", action = "List" }
          );

            routes.MapRoute(
               name: "RSSFeed",
               url: "Enterprsie/RssFeed",
               defaults: new { controller = "Home", action = "Feed", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "LogOff",
              url: "Account/LogOff",
              defaults: new { controller = "Account", action = "LogOff" }
          );

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
             );
        }
    }
}