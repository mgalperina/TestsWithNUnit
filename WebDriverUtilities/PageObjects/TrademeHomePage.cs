using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TrademeTests.PageObjects
{
    public class TrademeHomePage
    {
        private WebDriverWait wait;
        public TrademeHomePage(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        } 


        [FindsBy(How = How.XPath, Using = "(.//*[contains(text(),'Property')])[2]")]
        public IWebElement propertyButton;


        public void ClickProperty()
        {
            wait.Until(_driver => propertyButton.Displayed);
            propertyButton.Click();
        }

    }
}
