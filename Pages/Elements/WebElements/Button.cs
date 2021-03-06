﻿using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Elements.WebElements
{
    public class Button : Element
    {
        public Button(IWebElement element, By by, ILog log) : base(element, by, log)
        {
        }

        public void Click()
        {
            this._log.Debug($"Click '{_by}' element");
            this.WebElement.Click();
        } 


    }
}
