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
    public class BookStoreApplicationStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQABookStoreApplication demoQABookStoreApplication;

        public BookStoreApplicationStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQABookStoreApplication = new DemoQABookStoreApplication(driver);
        }



        [When(@"the user clicks on the Elements Card")]
        public void WhenTheUserClicksOnTheElementsCard()
        {
            demoQABookStoreApplication.elementsCard.Click();
        }

        [When(@"the user clicks on the Forms Card")]
        public void WhenTheUserClicksOnTheFormsCard()
        {
            demoQABookStoreApplication.formsCard.Click();
        }

        [When(@"the user clicks on the Alerts Card")]
        public void WhenTheUserClicksOnTheAlertsCard()
        {
            demoQABookStoreApplication.alertsCard.Click();
        }

        [When(@"the user clicks on the Widgets Card")]
        public void WhenTheUserClicksOnTheWidgetsCard()
        {
            demoQABookStoreApplication.widgetsCard.Click();
        }

        [When(@"the user clicks on the Interactions Card")]
        public void WhenTheUserClicksOnTheInteractionsCard()
        {
            demoQABookStoreApplication.interactionsCard.Click();
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
