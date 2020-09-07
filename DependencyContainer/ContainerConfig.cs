using ApplicationPages;
using ApplicationPages.Interfaces;
using Autofac;
using Core;
using Core.UI;
using OpenQA.Selenium;

namespace DependencyContainer
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BrowserFactory>().As<IBrowserFactory>().SingleInstance();
            builder.RegisterType<ApplicationConfiguration>().AsSelf().SingleInstance();
            builder.Register<Pages>((c, s) => new Pages(s.Named<IWebDriver>("_driver"), s.Named<TestSettings>("_testSettings"))).As<IUoW>();
            //builder.RegisterType<Pages>().As<IUoW>().WithParameter(new TypedParameter(typeof(IWebDriver), "driver"));
            return builder.Build();
        }
    }
}
