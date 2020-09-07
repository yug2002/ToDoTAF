using Core.Helpers;
using OpenQA.Selenium;
using Selenium.WebDriver.WaitExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements
{
    public class Element
    {
        protected ILog _log;
        private readonly Lazy<IWebElement> _lazy;
        protected IWebElement WebElement => _lazy.Value;
        protected By _by;
        public Element(IWebElement element, By by, ILog log)
        {
            _log = log;
            _lazy = new Lazy<IWebElement>(element);
            _by = by;
        }

        public string Text()
        {
            return WebElement.Text;
        }

        public bool Displayed()
        {
            Wait.For(() => WebElement.Displayed);
            return WebElement.Displayed;
        }
    }
}
