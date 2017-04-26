using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverUtilities.PageObjects
{
    public class SearchResultsJobs
    {  public SearchResultsJobs(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "search-summary")]
        public IWebElement searchResultsText;

        [FindsBy(How = How.XPath, Using = ".//*[@class='attSearchResultList']")]
        public IWebElement attributeSearchResult;

        public string GetSearchResultsText()
        {
            return searchResultsText.Text;
        }
        public string GetResultsTextAttributeOnResultsPage()
        {
            return attributeSearchResult.Text;
        }

    }
}
