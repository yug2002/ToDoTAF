using ApplicationPages.Components;
using Core.Helpers;
using OpenQA.Selenium;
using System;

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

        public Component FindComponent(By by)
        {
            var element = this.WebElement.FindElement(by);
            var comp = ObjectFactory.Get<Component>(element, _by, by, _log);
            return comp;
        }
    }
}
