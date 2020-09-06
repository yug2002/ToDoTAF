using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements
{
    public class Element
    {
        private readonly Lazy<IWebElement> _lazy;
        protected IWebElement WebElement => _lazy.Value;
        public Element(IWebElement element)
        {
            _lazy = new Lazy<IWebElement>(element);
        }

        public string Text()
        {
            return WebElement.Text;
        }
    }
}
