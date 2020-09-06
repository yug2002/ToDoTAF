using OpenQA.Selenium;
using ApplicationPages.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace ApplicationPages.PageRepository
{
    public class HomePageRepository : IRepository<HomePage>
    {
        IWebDriver _webDriver;
        ITestSettings _testSetting;
        public HomePageRepository(IWebDriver webDriver, ITestSettings testSetting)
        {
            _webDriver = webDriver;
            _testSetting = testSetting;
        }
        public HomePage Get()
        {
            return new HomePage(_webDriver, _testSetting);
        }
    }
}
