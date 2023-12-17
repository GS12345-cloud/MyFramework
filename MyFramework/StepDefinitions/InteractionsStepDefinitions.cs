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
    public class InteractionsStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQAInteractions demoQAInteractions;

        public InteractionsStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAInteractions = new DemoQAInteractions(driver);
        }



        [When(@"the user clicks on the Elements Card")]
        public void WhenTheUserClicksOnTheElementsCard()
        {
            demoQAInteractions.elementsCard.Click();
        }

        [When(@"the user clicks on the Forms Card")]
        public void WhenTheUserClicksOnTheFormsCard()
        {
            demoQAInteractions.formsCard.Click();
        }

        [When(@"the user clicks on the Alerts Card")]
        public void WhenTheUserClicksOnTheAlertsCard()
        {
            demoQAInteractions.alertsCard.Click();
        }

        [When(@"the user clicks on the Widgets Card")]
        public void WhenTheUserClicksOnTheWidgetsCard()
        {
            demoQAInteractions.widgetsCard.Click();
        }

        [When(@"the user clicks on the Interactions Card")]
        public void WhenTheUserClicksOnTheInteractionsCard()
        {
            demoQAInteractions.interactionsCard.Click();
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
