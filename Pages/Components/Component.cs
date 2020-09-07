using ApplicationPages.Elements;
using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Components
{
    public class Component : Element
    {
        protected By _compBy;
        public Component(IWebElement element, By by, ILog log) : base(element, by, log)
        {            
        }

        public Component(IWebElement element, By by, By comp, ILog log) : base (element, by, log)
        {
            _compBy = comp;
        }


    }
}
