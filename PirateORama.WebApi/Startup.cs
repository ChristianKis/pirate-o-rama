using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Owin;
using PirateORama.WebApi.Controllers;
using PirateORama.WebApi.Model.Repositories;
using PirateORama.WebApi.Repositories;
using Unity.WebApi;

namespace PirateORama.WebApi.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var assembly = typeof (EventsController).Assembly;
            var configuration = new HttpConfiguration();
            var container = new UnityContainer();
            container.RegisterType<IEventRepository, InmemoryEventRepository>();
            configuration.DependencyResolver = new UnityDependencyResolver(container);
            configuration.MapHttpAttributeRoutes();
            appBuilder.UseWebApi(configuration);
        }
    }
}
