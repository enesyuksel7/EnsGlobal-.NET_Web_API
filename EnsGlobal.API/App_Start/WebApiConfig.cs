using EnsGlobal.API.Attribute;
using EnsGlobal.API.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EnsGlobal.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new ApiExceptionAttribute()); //Hata kodları
            config.MessageHandlers.Add(new APIKeyHandler()); //API Key mesajları

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

            );
        }
    }
}
