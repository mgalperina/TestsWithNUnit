using NUnit.Framework;
using OpenQA.Selenium;
using WebDriverUtilities.PageObjects;
using WebDriverUtilities.WebDriver;

namespace TrademeTests.JobsTests
{
    [TestFixture]
    public class JobSearchingTests
    {
        private IWebDriver _driver;
        private TrademeHomePage _homePage;
        private JobsHomePage _jobsHomePage;
        private SearchResultsJobs _searchResultsJob;

        [SetUp]
        public void SetUp()
        {
            var driverFactory = new DriverFactory();
            _driver = driverFactory.GetBrowser();
            _homePage = new TrademeHomePage(_driver);
            _jobsHomePage = new JobsHomePage(_driver);
            _searchResultsJob = new SearchResultsJobs(_driver);
        }

        [Test]
        public void SearchJobsWithDefaultInputs()
        {

            _homePage.ClickJobs();
            _jobsHomePage.ClickSearchJobs();

            Assert.AreEqual("Search results", _searchResultsJob.GetSearchResultsText());
        }
        [Test]
        public void SearchJobsWithKeywordTesting()
        {
            _homePage.ClickJobs();
            _jobsHomePage.InputKeyword("testing");
            _jobsHomePage.ClickSearchJobs();

            Assert.AreEqual("Keywords: 'testing'", _searchResultsJob.GetResultsTextAttributeOnResultsPage());
        }

        [Test]
        public void SearchJobsInAucklandCityInTesting()
        {
            _homePage.ClickJobs();
            _jobsHomePage.SelectRegionJobs("Auckland");
            _jobsHomePage.SelectDistrictJobs("Auckland City");
            _jobsHomePage.SelectJobCategory("IT");
            _jobsHomePage.SelectJobSubcategory("Testing");
            _jobsHomePage.ClickSearchJobs();

            Assert.AreEqual("Search results for IT > Testing jobs\r\nAuckland, Auckland City", _searchResultsJob.GetSearchResultsText());
        }

        [Test]
        public void SearchJobsInProgrammingWith90To140HourlyPay()
        {
            _homePage.ClickJobs();
            _jobsHomePage.SelectJobCategory("IT");
            _jobsHomePage.SelectJobSubcategory("Programming & development");
            _jobsHomePage.SelectHourlyPayButton();
            _jobsHomePage.SelectHourlyPayMinimum("$90");
            _jobsHomePage.SelectHourlyPayMaximum("$140");
            _jobsHomePage.ClickSearchJobs();

            Assert.AreEqual("Search results for IT > Programming & development jobs\r\n$90 - $140", _searchResultsJob.GetSearchResultsText());
        }


        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }

    }
}
