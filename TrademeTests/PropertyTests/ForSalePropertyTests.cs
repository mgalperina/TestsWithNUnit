using OpenQA.Selenium;
using NUnit.Framework;
using WebDriverUtilities.PageObjects;
using WebDriverUtilities.WebDriver;


namespace TrademeTests
{
    [TestFixture]
    public class ForSalePropertyTests
    {
        private IWebDriver _driver;
        private TrademeHomePage _homePage;
        private PropertyHomePage _propertyHomePage;
        private SearchResultsPropertyPage _searchResultsPage;

/// <summary>
/// how to put browser's info into app.config??instead of storing it here
/// </summary>
        [SetUp]
        public void SetUp()
        {
           
            var driverFactory = new DriverFactory();
            _driver = driverFactory.GetBrowser("chrome", "50");
            _homePage = new TrademeHomePage(_driver);
            _propertyHomePage = new PropertyHomePage(_driver);
            _searchResultsPage = new SearchResultsPropertyPage(_driver);
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

        [Test]
        public void SearchHouseInAucklandCityWithTwoBedroomsToFiveAndPrice350To850()
        {
            _homePage.ClickProperty();
            _propertyHomePage.SelectForSaleRegion("Auckland");
            _propertyHomePage.SelectForSaleDistrict("Auckland City");
            _propertyHomePage.SelectBedroomsMinimum("3");
            _propertyHomePage.SelectBedroomsMaximum("5");
            _propertyHomePage.SelectPriceMinimum(6);
            _propertyHomePage.SelectPriceMaximum(16);
            _propertyHomePage.SelectPropertyType("House");
            _propertyHomePage.ClickSearchResidential();

            Assert.AreEqual("House, 3 - 5 bedrooms, $350,000 - $850,000", _searchResultsPage.GetResultsTextAttOnResultsPage());
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
