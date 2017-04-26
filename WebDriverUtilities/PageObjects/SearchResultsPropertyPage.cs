using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace WebDriverUtilities.PageObjects
{
    public class SearchResultsPropertyPage
    {

        public SearchResultsPropertyPage(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "search-summary")]
        public IWebElement searchResultsText;

        [FindsBy(How = How.ClassName, Using = "find-agent-link-div")]
        public IWebElement findAgentsInText;

        [FindsBy(How = How.ClassName, Using = "advanced-property-att")]
        public IWebElement attText;

        public string GetSearchResultsText()
        {
            return searchResultsText.Text;
        }
        public string GetResultsTextOnResultsPage()
        {
            return findAgentsInText.Text;
        }

        public string GetResultsTextAttOnResultsPage()
        {
            return attText.Text;
        }

    }
}
