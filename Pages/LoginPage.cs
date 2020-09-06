using ApplicationPages.Base;
using ApplicationPages.Interfaces;
using Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver webDriver, ITestSettings settings) : base(webDriver, settings)
        {
        }       
    }
}
