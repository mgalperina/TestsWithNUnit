using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;


namespace WebDriverUtilities.WebDriver
{
    /// <summary>
    /// Class that represents factory that creates IWebDriver
    /// </summary>
    public class DriverFactory
    {
        public IWebDriver GetBrowser(string browser, string browserVersion)
        {
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, browser);
            capabilities.SetCapability(CapabilityType.Version, browserVersion);
            var _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.trademe.co.nz/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
    }
}
