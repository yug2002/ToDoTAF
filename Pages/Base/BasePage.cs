using ApplicationPages.Elements;
using ApplicationPages.Interfaces;
using Core;
using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Element FindElement(By by)
        {
            return ObjectFactory.Get<Element>(_webDriver.FindElement(by));
        }

        public T FindElement<T>(By by) where T : Element
        { 
            return ObjectFactory.Get<T>(_webDriver.FindElement(by));
        }

        public List<Element> FindElements(By by)
        {
            var listElements = _webDriver.FindElements(by).ToList();
            return listElements.Select(element => ObjectFactory.Get<Element>(element)).ToList();
        }

        public List<T> FindElements<T>(By by) where T: Element
        {
            var listElements = _webDriver.FindElements(by).ToList();
            return listElements.Select(element => ObjectFactory.Get<T>(element)).ToList();
        }
    }
}
