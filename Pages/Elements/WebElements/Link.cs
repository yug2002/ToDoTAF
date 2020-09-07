using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements.WebElements
{
    public class Link : Element
    {
        public Link(IWebElement element, By by, ILog log) : base(element, by, log)
        {
        }

        public void Click()
        {
            this.WebElement.Click();
        }
    }
}
