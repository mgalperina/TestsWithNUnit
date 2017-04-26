using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace WebDriverUtilities.PageObjects
{
    public class PropertyHomePage
    {
        private IWebDriver _driver;
        private WebDriverWait wait;

        public PropertyHomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(), 'Search residential')]")]
        public IWebElement searchResidentialButton;

        [FindsBy(How = How.Id, Using = "PropertyBedroomsMin")]
        public IWebElement propertyBedroomsMin;

        [FindsBy(How = How.Id, Using = "PropertyRegionSelect")]
        public IWebElement propertyRegionDDL;

        [FindsBy(How = How.Id, Using = "PropertyDistrictSelect")]
        public IWebElement propertyDistrictDDL;

        [FindsBy(How = How.Id, Using = "PropertyForSalePriceMin")]
        public IWebElement propertyMinPriceDDL;

        [FindsBy(How = How.Id, Using = "PropertyBedroomsMax")]
        public IWebElement propertyBedroomsMax;

        [FindsBy(How = How.Id, Using = "PropertyForSalePriceMin")]
        public IWebElement propertyPriceMin;

        [FindsBy(How = How.Id, Using = "PropertyForSalePriceMax")]
        public IWebElement propertyPriceMax;

        [FindsBy(How = How.XPath, Using = "(.//span[contains(text(),'All property types')])[1]")]
        public IWebElement propertyForSaleType;

        [FindsBy(How = How.XPath, Using = ".//div[3]/div/div/div/ul/li[3]/label")]
        public IWebElement housePropertyForSaleType;

        public void ClickSearchResidential()
        {
            searchResidentialButton.Click();
        }
        public void SelectBedroomsMinimum(string valueToSelect)
        {
            var selectElement = new SelectElement(propertyBedroomsMin);
            selectElement.SelectByValue(valueToSelect);
        }
        public void SelectBedroomsMaximum(string valueToSelect)
        {
            var selectElement = new SelectElement(propertyBedroomsMax);
            selectElement.SelectByValue(valueToSelect);
        }
        public void SelectPriceMinimum(int intToSelect)
        {
            var selectElement = new SelectElement(propertyPriceMin);
            selectElement.SelectByIndex(intToSelect);
        }

        public void SelectPriceMaximum(int intToSelect)
        {
            var selectElement = new SelectElement(propertyPriceMax);
            selectElement.SelectByIndex(intToSelect);
        }

        public void SelectForSaleRegion(string textToSelect)
        {
            var selectElement = new SelectElement(propertyRegionDDL);
            selectElement.SelectByText(textToSelect);
        }
        public void SelectForSaleDistrict(string textToSelect)
        {
            var test = _driver.FindElement
                (By.XPath("//select[@id='PropertyDistrictSelect']/option[starts-with(text(), '" + textToSelect + "')]"));
            test.Click();
        }
        //public void SelectPropertyType()
        //{
        //    propertyForSaleType.Click();
        //    wait.Until(_driver => housePropertyForSaleType.Displayed);
        //    housePropertyForSaleType.Click();
        //}
        public void SelectPropertyType(string textToSelect)
        {
            var test = _driver.FindElement
                (By.XPath("(//span[@class='placeholder'])[4]//*[starts-with(text(), '" + textToSelect + "')]"));
            test.Click();
        }

        //public void SelectPropertyType()
        //{
        //    IList<IWebElement> propertyTypesForSale = _driver.FindElements(By.XPath("(.//span[contains(text(),'All property types')])[1]"));

        //}


    }
}
