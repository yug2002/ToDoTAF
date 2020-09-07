using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements
{
    public class Element
    {
        private ILog _log;
        private readonly Lazy<IWebElement> _lazy;
        protected IWebElement WebElement => _lazy.Value;
        public Element(IWebElement element, ILog log)
        {
            _log = log;
            _lazy = new Lazy<IWebElement>(element);
        }

        public string Text()
        {
            return WebElement.Text;
        }
    }
}
