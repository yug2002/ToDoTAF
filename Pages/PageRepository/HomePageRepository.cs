using OpenQA.Selenium;
using Pages.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages.PageRepository
{
    public class HomePageRepository : IRepository<HomePage>
    {
        IWebDriver _webDriver;
        public HomePageRepository(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public HomePage Get()
        {
            return new HomePage(_webDriver);
        }
    }
}
