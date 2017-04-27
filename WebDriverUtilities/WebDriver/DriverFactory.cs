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
        public IWebDriver GetBrowser()
        {
            var settings = new Settings();
            var capabilities = Capabilities.GetCapabilities(settings);
            var _driver = new RemoteWebDriver(new Uri(settings.RemoteDriver), capabilities);
            _driver.Navigate().GoToUrl(settings.Url);
            _driver.Manage().Window.Maximize();
            return _driver;
        }       
    }
}
