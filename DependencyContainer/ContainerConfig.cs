using ApplicationPages;
using ApplicationPages.Interfaces;
using Autofac;
using Core;
using Core.UI;

namespace DependencyContainer
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BrowserFactory>().As<IBrowserFactory>().SingleInstance();
            builder.RegisterType<ApplicationConfiguration>().AsSelf().SingleInstance();
            builder.RegisterType<Pages>().As<IUoW>();
            return builder.Build();
        }
    }
}
