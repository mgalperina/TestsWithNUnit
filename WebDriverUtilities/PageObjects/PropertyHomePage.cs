using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TrademeTests.PageObjects
{
    public class PropertyHomePage
    {
        private IWebDriver _driver;

        public PropertyHomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

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
    }
}
