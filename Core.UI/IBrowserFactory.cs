using OpenQA.Selenium;

namespace Core.UI
{
    public interface IBrowserFactory
    {
        IWebDriver GetDriver();
        void Start(string browser);
        void Stop();
    }
}