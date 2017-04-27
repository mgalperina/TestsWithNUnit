using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace WebDriverUtilities.PageObjects
{
    public class JobsHomePage : BasePageObject
    {
        public JobsHomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        [FindsBy(How = How.XPath, Using = ".//*[contains(text(),'Search Jobs')]")]
        public IWebElement searchJobsButton;

        [FindsBy(How = How.Name, Using = "keywords")]
        public IWebElement keywordField;

        [FindsBy(How = How.Id, Using = "SearchTabs1_JobsSearchFormControl_jobsTopTierCategory")]
        public IWebElement jobCategory;

        [FindsBy(How = How.Id, Using = "SearchTabs1_JobsSearchFormControl_jobsSecondTierCategory")]
        public IWebElement jobSubcategory;

        [FindsBy(How = How.Id, Using = "SearchTabs1_JobsSearchFormControl_jobsTopTierLocation")]
        public IWebElement jobsRegionDDL;

        [FindsBy(How = How.Id, Using = "HourlyPayType")]
        public IWebElement hourlyPayButton;

        [FindsBy(How = How.XPath, Using = "(.//*[@class='drop-container'])[9]")]
        public IWebElement hourlyMinPayDDL;

        [FindsBy(How = How.XPath, Using = "(.//*[@class='drop-container'])[10]")]
        public IWebElement hourlyMaxPayDDL;

      
        public void ClickSearchJobs()
        {
            searchJobsButton.Click();
        }
        public void InputKeyword(string textAsKeyword)
        {
            keywordField.Click();
            keywordField.SendKeys(textAsKeyword);
        }
        public void SelectRegionJobs(string textToSelect)
        {
            var selectElement = new SelectElement(jobsRegionDDL);
            selectElement.SelectByText(textToSelect);
        }
        public void SelectDistrictJobs(string textToSelect)
        {
            var test = _driver.FindElement
            (By.XPath("(//select[@class='drop-select'])[3]/option[starts-with(text(), '" + textToSelect + "')]"));
            test.Click();
        }
        public void SelectJobCategory(string textToSelect)
        {
            var test = _driver.FindElement
            (By.XPath("//select[@class='drop-select jobsTopTierCategory']/option[starts-with(text(), '" + textToSelect + "')]"));
            test.Click();
        }
        public void SelectJobSubcategory(string textToSelect)
        {
            var test = _driver.FindElement
               (By.XPath("(//select[@class='drop-select'])[4]/option[starts-with(text(), '" + textToSelect + "')]"));
            test.Click();
        }
        public void SelectHourlyPayButton()
        {
            hourlyPayButton.Click();
        }
        public void SelectHourlyPayMinimum(string textToSelect)
        {
            var test = _driver.FindElement
               (By.XPath("(//select[@class='drop-select'])[7]/option[starts-with(text(), '" + textToSelect + "')]"));
            test.Click(); 
        }
        public void SelectHourlyPayMaximum(string textToSelect)
        {
            var test = _driver.FindElement
              (By.XPath("(//select[@class='drop-select'])[8]/option[starts-with(text(), '" + textToSelect + "')]"));
            test.Click();
        }

    }
}
