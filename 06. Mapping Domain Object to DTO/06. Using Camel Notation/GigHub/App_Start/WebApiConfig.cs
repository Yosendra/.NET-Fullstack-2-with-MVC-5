﻿using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GigHub
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // logic for the setting camelCase for api return
            var settings = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
