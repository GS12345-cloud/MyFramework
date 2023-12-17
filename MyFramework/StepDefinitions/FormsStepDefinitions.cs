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
    public class FormsStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQAForms demoQAForms;

        public FormsStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAForms = new DemoQAForms(driver);
        }

        [Given(@"the user is on the forms page")]
        public void GivenTheUserIsOnTheFormsPage()
        {
            throw new PendingStepException();
        }

        [Then(@"the user submits their details")]
        public void ThenTheUserSubmitsTheirDetails()
        {
            throw new PendingStepException();
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
