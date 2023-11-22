using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MyFramework
{
    [Binding]
    public class GoogleSearchSteps
    {
        private readonly IWebDriver driver;
        private readonly GoogleSearchPage googleSearchPage;

        public GoogleSearchSteps()
        {
            // Initialize the page object with the WebDriver

            driver = new ChromeDriver();
            googleSearchPage = new GoogleSearchPage(driver);
        }

        [Given(@"I am on the Google homepage")]
        public void GivenIAmOnTheGoogleHomepage()
        {
            googleSearchPage.GoTo();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            googleSearchPage.Search(searchTerm);
        }

        [Then(@"I should see search results related to ""(.*)""")]
        public void ThenIShouldSeeSearchResultsRelatedTo(string searchTerm)
        {
            // Add assertions or verifications here
            
            Assert.IsTrue(driver.Title.Contains(searchTerm));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Cleanup (close the browser, etc.)
            driver.Quit();
        }
    }
}
