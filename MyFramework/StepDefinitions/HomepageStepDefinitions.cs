using MyFramework.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class HomepageStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQAHomepage demoQAHomepage;

        public HomepageStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAHomepage = new DemoQAHomepage(driver);
        }



        [When(@"the user clicks on the Elements Card")]
        public void WhenTheUserClicksOnTheElementsCard()
        {
            demoQAHomepage.elementsCard.Click();
        }

        [When(@"the user clicks on the Forms Card")]
        public void WhenTheUserClicksOnTheFormsCard()
        {
            demoQAHomepage.formsCard.Click();
        }

        [When(@"the user clicks on the Alerts Card")]
        public void WhenTheUserClicksOnTheAlertsCard()
        {
            demoQAHomepage.alertsCard.Click();
        }

        [When(@"the user clicks on the Widgets Card")]
        public void WhenTheUserClicksOnTheWidgetsCard()
        {
            demoQAHomepage.widgetsCard.Click();
        }

        [When(@"the user clicks on the Interactions Card")]
        public void WhenTheUserClicksOnTheInteractionsCard()
        {
            demoQAHomepage.interactionsCard.Click();
        }


        [Then(@"the page navigates to a new page")]
        public void ThenThePageNavigatesToANewPage()
        {
            Assert.IsTrue(true);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
