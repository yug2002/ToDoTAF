using OpenQA.Selenium;
using ApplicationPages.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Core.Helpers;

namespace ApplicationPages.PageRepository
{
    public class HomePageRepository : IRepository<HomePage>
    {
        IWebDriver _webDriver;
        ITestSettings _testSetting;
        ILog _log;

        public HomePageRepository(IWebDriver webDriver, ITestSettings testSetting, ILog log)
        {
            _webDriver = webDriver;
            _testSetting = testSetting;
            _log = log;
        }
        public HomePage Get()
        {
            return new HomePage(_webDriver, _testSetting, _log);
        }
    }
}
