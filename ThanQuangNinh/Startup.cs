using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;
using Unity.AspNet.WebApi;

[assembly: OwinStartup(typeof(ThanQuangNinh.Startup))]

namespace ThanQuangNinh
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            DependencyResolver.Current.GetService<IController>();
            var resolver = new UnityDependencyResolver(UnityConfig.Container);
            HttpConfiguration config = new HttpConfiguration();
            config.DependencyResolver = resolver;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            app.UseWebApi(config);


        }
    }
}
