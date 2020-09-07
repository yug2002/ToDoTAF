using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Core.UI
{
    public class BrowserFactory : IBrowserFactory
    {
        private IWebDriver _webdriver;

        public BrowserFactory() { }

        private IWebDriver GetChromeBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--whitelisted-ips");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-extensions");
            //options.AddAdditionalCapability("useAutomationExtension", false);
            //options.AddExcludedArgument("enable-automation");
            //options.AddUserProfilePreference("credentials_enable_service", false);
            //options.AddUserProfilePreference("profile.password_manager_enabled", false);
            return new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, options);
        }

        private void SetBrowser(string browser)
        {
            this._webdriver = browser switch
            {
                "Chrome" => GetChromeBrowser(),
                "FireFox" => null,
                _ => throw new Exception("There is no any browser"),
            };
        }

        public void Start(string browser)
        {
            SetBrowser(browser);
            _webdriver.Manage().Window.Maximize();
        }

        public IWebDriver GetDriver()
        {
            return _webdriver;
        }

        public void Stop()
        {
            _webdriver.Quit();
        }
    }
}
