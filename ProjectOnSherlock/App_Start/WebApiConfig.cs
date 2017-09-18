using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjectOnSherlock
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

        //    // Web API routes
       config.MapHttpAttributeRoutes();
        //    config.Routes.MapHttpRoute(
        //    name: "Lead",
        //    routeTemplate: "api/myschool/{id}",
        //    defaults: new { controller = "Lead", id = RouteParameter.Optional }
        //    //constraints: new { id = "/d+" }
        //);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
               
            );
        }
    }
}



