using ApplicationPages;
using ApplicationPages.Interfaces;
using Autofac;
using Core;
using Core.UI;
using DependencyContainer;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Tests.UI
{    
    public class BaseUITest
    {
        protected IUoW _pages;
        protected ITestSettings _testSettings;
        protected IBrowserFactory _browser;

        [OneTimeSetUp]
        public void SetUp()
        {
            var config = ContainerConfig.Configure();
            using (var scope = config.BeginLifetimeScope())
            {
                _testSettings = scope.Resolve<ApplicationConfiguration>().GetApplicationConfiguration<TestSettings>();
                _browser = scope.Resolve<IBrowserFactory>();
                _browser.Start(_testSettings.Browser);
                _pages = scope.Resolve<IUoW>(new NamedParameter("_driver", _browser.GetDriver()), new NamedParameter("_testSettings", _testSettings));
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _browser.Stop();
        }

        protected HomePage HomePage => _pages.HomePage.Get();
    }
}
