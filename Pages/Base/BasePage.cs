using ApplicationPages.Components;
using ApplicationPages.Elements;
using ApplicationPages.Interfaces;
using Core;
using Core.Helpers;
using OpenQA.Selenium;
using Selenium.WebDriver.WaitExtensions;

using System.Collections.Generic;
using System.Linq;

namespace ApplicationPages.Base
{
    public abstract class BasePage : IBasePage
    {
        protected IWebDriver _webDriver;
        protected ITestSettings _settings;
        protected ILog _log;

        public BasePage(IWebDriver webDriver, ITestSettings settings, ILog log)
        {
            _webDriver = webDriver;
            _settings = settings;
            _log = log;
        }

        public virtual void Open(string url)
        {
            _webDriver.Url = url;
        }

        protected Element FindElement(By by)
        {
            _log.Debug($"find element {by}");
            WaitElement(by);
            return ObjectFactory.Get<Element>(_webDriver.FindElement(by), by, _log);
        }

        protected T FindElement<T>(By by) where T : Element
        {
            WaitElement(by);
            return ObjectFactory.Get<T>(_webDriver.FindElement(by), by, _log);
        }

        protected List<Element> FindElements(By by)
        {
            Wait.For(() => _webDriver.FindElements(by).Count > 0);
            var listElements = _webDriver.FindElements(by).ToList();
            return listElements.Select(element => ObjectFactory.Get<Element>(element, by, _log)).ToList();
        }

        protected List<T> FindElements<T>(By by) where T: Element
        {
            Wait.For(() => _webDriver.FindElements(by).Count > 0);
            var listElements = _webDriver.FindElements(by).ToList();
            return listElements.Select(element => ObjectFactory.Get<T>(element, by, _log)).ToList();
        }

        protected void WaitElement(By by, int delay)
        {
            _webDriver.Wait(delay).ForElement(by).ToExist();
        }

        protected void WaitElement(By by)
        {
            _webDriver.Wait(_settings.Timeout).ForElement(by).ToExist();
        }

        protected Component FindComponent(By by)
        {
            return ObjectFactory.Get<Component>(_webDriver.FindElement(by), by, _log);
        }
    }
}
