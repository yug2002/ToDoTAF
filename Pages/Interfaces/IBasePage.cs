using ApplicationPages.Elements;
using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationPages.Interfaces
{
    public interface IBasePage
    {        
        void Open(string url);
    }
}
