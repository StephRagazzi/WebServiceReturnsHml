﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiContrib.Formatting.Razor;

namespace WebService2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.Add(new RazorViewFormatter());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
