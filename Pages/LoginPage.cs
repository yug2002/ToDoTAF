using ApplicationPages.Base;
using ApplicationPages.Interfaces;
using Core;
using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver, ITestSettings settings, ILog log) : base(webDriver, settings, log)
        {
        }       
    }
}
