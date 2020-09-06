using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements.WebElements
{
    public class Link : Element
    {
        public Link(IWebElement element) : base(element)
        {
        }

        public void Click()
        {
            this.WebElement.Click();
        }
    }
}
