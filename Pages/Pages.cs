using OpenQA.Selenium;
using Pages.Interfaces;
using Pages.PageRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pages
{
    public class Pages
    {
        IWebDriver _webDriver;

        public Pages(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IRepository<HomePage> HomePage => new HomePageRepository(_webDriver);

    }
}
