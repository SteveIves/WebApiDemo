using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebHost
{
    /// <summary>
    ///
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // This filter runs requests through ModelState validation and, if validation fails,
            // returns an error response without even calling the operation
            config.Filters.Add(new WebApiServices.Filters.ValidateModelAttribute());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
