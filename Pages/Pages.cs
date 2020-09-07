using OpenQA.Selenium;
using ApplicationPages.Interfaces;
using ApplicationPages.PageRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Core.Helpers;

namespace ApplicationPages
{
    public class Pages : IUoW
    {
        IWebDriver _webDriver;
        ITestSettings _testSetting;
        ILog _log;

        public Pages(IWebDriver webDriver, ITestSettings testSettings, ILog log)
        {
            _webDriver = webDriver;
            _testSetting = testSettings;
            _log = log;
        }

        public IRepository<HomePage> HomePage => new HomePageRepository(_webDriver, _testSetting, _log);

        public IRepository<LoginPage> LoginPage => throw new NotImplementedException();
    }
}
