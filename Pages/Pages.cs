using OpenQA.Selenium;
using ApplicationPages.Interfaces;
using ApplicationPages.PageRepository;
using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace ApplicationPages
{
    public class Pages : IUoW
    {
        IWebDriver _webDriver;
        ITestSettings _testSetting;

        public Pages(IWebDriver webDriver, ITestSettings testSettings)
        {
            _webDriver = webDriver;
            _testSetting = testSettings;
        }

        public IRepository<HomePage> HomePage => new HomePageRepository(_webDriver, _testSetting);

        public IRepository<LoginPage> LoginPage => throw new NotImplementedException();
    }
}
