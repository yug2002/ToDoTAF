using ApplicationPages;
using ApplicationPages.Interfaces;
using Autofac;
using Core;
using Core.Helpers;
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
        protected ILog _log;

        [OneTimeSetUp]
        public void SetUp()
        {
            var config = ContainerConfig.Configure();
            using (var scope = config.BeginLifetimeScope())
            {
                _testSettings = scope.Resolve<ApplicationConfiguration>().GetApplicationConfiguration<TestSettings>();
                _log = scope.Resolve<ILog>();
                _browser = scope.Resolve<IBrowserFactory>(new TypedParameter(typeof(ILog), _log));
                _browser.Start(_testSettings.Browser);
                _pages = scope.Resolve<IUoW>(new NamedParameter("_driver", _browser.GetDriver()),
                    new NamedParameter("_testSettings", _testSettings), 
                    new NamedParameter("_log", _log));
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
