using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

using WebDriverUtilities.WebDriver;

namespace WebDriverUtilities.PageObjects
{
    public class BasePageObject
    {
        protected IWebDriver _driver;
        protected WebDriverWait wait;
     
        public BasePageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            wait = WaitHelper.ReadWaitFromSettings(_driver);
        }
    }
}
