using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace WebDriverUtilities.WebDriver
{
    public static class WaitHelper
    {
        public static WebDriverWait ReadWaitFromSettings(IWebDriver driver)
        {
            var settings = new Settings();
            var wait = new WebDriverWait(driver, settings.WaitBrowserToLaunch);
            return wait;
        }
    }
}
