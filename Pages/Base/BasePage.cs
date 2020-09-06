using ApplicationPages.Elements;
using ApplicationPages.Interfaces;
using Core;
using Core.Helpers;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationPages.Base
{
    public abstract class BasePage : IBasePage
    {
        protected IWebDriver _webDriver;
        protected ITestSettings _settings;
        public BasePage(IWebDriver webDriver, ITestSettings settings)
        {
            _webDriver = webDriver;
            _settings = settings;
        }

        public virtual void Open(string url)
        {
            _webDriver.Url = url;
        }

        protected Element FindElement(By by)
        {
            return ObjectFactory.Get<Element>(_webDriver.FindElement(by));
        }

        protected T FindElement<T>(By by) where T : Element
        { 
            return ObjectFactory.Get<T>(_webDriver.FindElement(by));
        }

        protected List<Element> FindElements(By by)
        {
            var listElements = _webDriver.FindElements(by).ToList();
            return listElements.Select(element => ObjectFactory.Get<Element>(element)).ToList();
        }

        protected List<T> FindElements<T>(By by) where T: Element
        {
            var listElements = _webDriver.FindElements(by).ToList();
            return listElements.Select(element => ObjectFactory.Get<T>(element)).ToList();
        }
    }
}
