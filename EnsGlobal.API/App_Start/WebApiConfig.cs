using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using EnsGlobal.API.Attributes;

namespace EnsGlobal.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new ApiExceptionAttributes()); //Metotlarda hata olması durumunda ApiExceptionAttributes sınıfını kullanarak hata kodu ve açıklaması gösterir

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
