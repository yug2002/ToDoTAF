using ApplicationPages;
using ApplicationPages.Interfaces;
using Autofac;
using Core;
using Core.Helpers;
using Core.UI;
using OpenQA.Selenium;

namespace DependencyContainer
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Log>().As<ILog>().SingleInstance();
            builder.RegisterType<BrowserFactory>().As<IBrowserFactory>().WithParameter(new TypedParameter(typeof(ILog), "_log")).SingleInstance();
            builder.RegisterType<ApplicationConfiguration>().AsSelf().SingleInstance();
            builder.Register<Pages>((ctx, @params) => new Pages(@params.Named<IWebDriver>("_driver"), @params.Named<TestSettings>("_testSettings"), @params.Named<ILog>("_log"))).As<IUoW>();            
            return builder.Build();
        }
    }
}
