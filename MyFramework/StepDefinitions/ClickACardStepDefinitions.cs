using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Text.RegularExpressions;
using MyFramework.Page;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class ClickACardStepDefinitions
    {
        public IWebDriver driver;
        private DemoQAHomepage demoQAHomepage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            demoQAHomepage = new DemoQAHomepage(driver);
            demoQAHomepage.driver.Manage().Window.Maximize();
        }

        public ClickACardStepDefinitions()
        {
            // Initialize the page object with the WebDriver

            driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
        }


        [Given(@"the user is on the Homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            driver.Navigate();
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.UrlToBe("https://demoqa.com/"));
        }

        [When(@"the user clicks on the Card")]
        public void WhenTheUserClicksOnTheCard()
        {
            demoQAHomepage.element.Click();
        }

        [Then(@"the page navigates to a new page")]
        public void ThenThePageNavigatesToANewPage()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
            bool url = wait.Until(ExpectedConditions.UrlMatches(new Regex("https://demoqa.com/elements").ToString()));
            Assert.IsTrue(url);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
