using OpenQA.Selenium;
using Pages.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages
{
    public class HomePage : IBasePage
    {
        IWebDriver _webDriver;
        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void Open(string url)
        {
            _webDriver.Url = url;
        }
    }
}
