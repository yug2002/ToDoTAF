using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements.WebElements
{
    public class Button : Element
    {
        public Button(IWebElement element, ILog log) : base(element, log)
        {
        }

        public void Click()
        {
            this.WebElement.Click();
        } 


    }
}
