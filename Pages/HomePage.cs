using Core;
using OpenQA.Selenium;
using ApplicationPages.Interfaces;
using ApplicationPages.Elements;
using ApplicationPages.Elements.WebElements;
using Core.Helpers;
using ApplicationPages.Base;

namespace ApplicationPages
{
    public class HomePage : BasePage
    {       

        public HomePage(IWebDriver webDriver, ITestSettings config, ILog log) : base(webDriver, config, log)
        {            
        }

        public void Open()
        {
            this.Open(_settings.BaseUrl);
        }

        public Element Title() => this.FindElement(By.XPath("//h1/span"));

        public Button ButtonByName(string name) => this.FindElement<Button>(By.XPath($"//a[./*[text()='{name}']]"));
    }
}
