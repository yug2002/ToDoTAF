using Autofac;
using Core.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyContainer
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BrowserFactory>().As<IBrowserFactory>().SingleInstance();
            return builder.Build();
        }
    }
}
