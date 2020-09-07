using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements.WebElements
{
    public class Input : Element
    {
        public Input(IWebElement element, ILog log) : base(element, log)
        {
        }

        public void Type(string text)
        {
            this.WebElement.SendKeys(text);
        }
    }
}
