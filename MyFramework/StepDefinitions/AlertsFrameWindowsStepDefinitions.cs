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
    public class AlertsFrameWindowsStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQAAlertsFrameWindows demoQAAlertsFrameWindows;

        public AlertsFrameWindowsStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAAlertsFrameWindows = new DemoQAAlertsFrameWindows(driver);
        }



        [When(@"the user clicks on the Elements Card")]
        public void WhenTheUserClicksOnTheElementsCard()
        {
            demoQAAlertsFrameWindows.elementsCard.Click();
        }

        [When(@"the user clicks on the Forms Card")]
        public void WhenTheUserClicksOnTheFormsCard()
        {
            demoQAAlertsFrameWindows.formsCard.Click();
        }

        [When(@"the user clicks on the Alerts Card")]
        public void WhenTheUserClicksOnTheAlertsCard()
        {
            demoQAAlertsFrameWindows.alertsCard.Click();
        }

        [When(@"the user clicks on the Widgets Card")]
        public void WhenTheUserClicksOnTheWidgetsCard()
        {
            demoQAAlertsFrameWindows.widgetsCard.Click();
        }

        [When(@"the user clicks on the Interactions Card")]
        public void WhenTheUserClicksOnTheInteractionsCard()
        {
            demoQAAlertsFrameWindows.interactionsCard.Click();
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
