using OpenQA.Selenium;
using NUnit.Framework;
using TrademeTests.PageObjects;
using TrademeTests.WebDriver;
using WebDriverUtilities.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TrademeTests
{
    [TestFixture]
    public class ForSalePropertyTests
    {
        private IWebDriver _driver;
        private TrademeHomePage _homePage;
        private PropertyHomePage _propertyHomePage;
        private SearchResultsPage _searchResultsPage;


        [SetUp]
        public void SetUp()
        {
            var driverFactory = new DriverFactory();
            _driver = driverFactory.GetBrowser("chrome", "50");
            _homePage = new TrademeHomePage(_driver);
            _propertyHomePage = new PropertyHomePage(_driver);
            _searchResultsPage = new SearchResultsPage(_driver);
        }


        [Test]
        public void SearchWithDefaultInputs()
        {
            
            _homePage.ClickProperty();
            _propertyHomePage.ClickSearchResidential();

            Assert.AreEqual("Search results", _searchResultsPage.GetSearchResultsText());

        }

        [Test]
        public void SearchForSaleInWaikato()
        {

            _homePage.ClickProperty();
            _propertyHomePage.SelectForSaleRegion("Waikato");
            _propertyHomePage.ClickSearchResidential();

            Assert.AreEqual("Find agents in Waikato", _searchResultsPage.GetResultsTextOnResultsPage());
        }

        [Test]

        public void SearchForSaleInHamilton()
        {
            _homePage.ClickProperty();
            _propertyHomePage.SelectForSaleRegion("Waikato");
            _propertyHomePage.SelectForSaleDistrict("Hamilton");
            _propertyHomePage.ClickSearchResidential();

            Assert.AreEqual("Find agents in Hamilton", _searchResultsPage.GetResultsTextOnResultsPage());
        }

        [Test]
        public void SearchForSaleWithThreeBedrooms()
        {
            _homePage.ClickProperty();
            _propertyHomePage.SelectBedroomsMinimum("3");
            _propertyHomePage.ClickSearchResidential();

            Assert.AreEqual("3 or more bedrooms", _searchResultsPage.GetResultsTextAttOnResultsPage());
        }
        [Test]
        public void SearchWithThreeBedroomsToFive()
        {
            _homePage.ClickProperty();
            _propertyHomePage.SelectBedroomsMinimum("3");
            _propertyHomePage.SelectBedroomsMaximum("5");
            _propertyHomePage.ClickSearchResidential();

            Assert.AreEqual("3 - 5 bedrooms", _searchResultsPage.GetResultsTextAttOnResultsPage());
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
