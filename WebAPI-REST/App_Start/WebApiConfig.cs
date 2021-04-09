using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI_REST
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web-API-Konfiguration und -Dienste

            // Web-API-Routen 
            // Attribute-based routing 
            config.MapHttpAttributeRoutes();



            // convention-based routing 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Test 
            config.Routes.MapHttpRoute(
                name: "myRoute",
                routeTemplate:"api/{controller}/{action}/{year}/{month}/{day}",
                defaults:new
                {
                    month=RouteParameter.Optional,
                    day=RouteParameter.Optional
                }, 
                constraints:new
                {
                    month=@"\d{0,2}",
                    day= @"\d{0,2}"
                }
                

                );
        }
    }
}
