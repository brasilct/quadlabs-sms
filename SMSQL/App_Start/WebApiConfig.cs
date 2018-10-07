using System.Net.Http;
using System.Web.Http;

namespace SMSQL.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApiGet",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { action = "Get", id = RouteParameter.Optional },
                constraints: new { httpMethod = new System.Web.Http.Routing.HttpMethodConstraint(HttpMethod.Get) }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApiPost",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { action = "Post", id = RouteParameter.Optional },
                constraints: new { httpMethod = new System.Web.Http.Routing.HttpMethodConstraint(HttpMethod.Post) }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApiPut",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { action = "Put", id = RouteParameter.Optional },
                constraints: new { httpMethod = new System.Web.Http.Routing.HttpMethodConstraint(HttpMethod.Put) }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApiDelete",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { action = "Delete", id = RouteParameter.Optional },
                constraints: new { httpMethod = new System.Web.Http.Routing.HttpMethodConstraint(HttpMethod.Delete) }
            );
        }
    }
}