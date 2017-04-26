using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriverUtilities.PageObjects
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

        [FindsBy(How = How.XPath, Using = "(.//*[contains(text(),'Jobs')])[3]")]
        public IWebElement jobsButton;


        public void ClickProperty()
        {
            wait.Until(_driver => propertyButton.Displayed);
            propertyButton.Click();
        }


        public void ClickJobs()
        {
            wait.Until(_driver => jobsButton.Displayed);
            jobsButton.Click();
        }

    }
}
