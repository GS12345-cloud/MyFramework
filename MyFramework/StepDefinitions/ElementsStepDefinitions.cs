using MyFramework.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class ElementsStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQAElements demoQAElements;
        public string elementsPageUrl = "https://demoqa.com/elements";

        public ElementsStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAElements = new DemoQAElements(driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }

        [Given(@"the user is on the elements page")]
        public void GivenTheUserIsOnTheElementsPage()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.UrlToBe(elementsPageUrl)))
            {
                Console.WriteLine("Pass");
            }
        }

        [Given(@"the user clicks on the Text Box field")]
        public void GivenTheUserClicksOnTheTextBoxField()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.textBoxFieldBy)) != null)
            {
                demoQAElements.TextBoxField.Click();
                // Url check as url changes
            }
        }

        [When(@"the user enters their details")]
        public void WhenTheUserEntersTheirDetails()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.FullNameBy)) != null)
            {
                demoQAElements.FullName.SendKeys("FullName");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.EmailBy)) != null)
            {
                demoQAElements.Email.SendKeys("test@gmail.com");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.CurrentAddressBy)) != null)
            {
                demoQAElements.CurrentAddress.SendKeys("My Address");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.PermanentAddressBy)) != null)
            {
                demoQAElements.PermanentAddress.SendKeys("My Permanent Address");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.SubmitButtonBy)) != null)
            {
                demoQAElements.SubmitButton.Click();
            }


            Thread.Sleep(5000); // Blocks thread but we can see visually, will use interface for screenshots later
        }

        [Then(@"the user observes a new box appearing below the submit button")]
        public void ThenTheUserObservesANewBoxAppearingBelowTheSubmitButton()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));


            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.TextBoxOutputResultBy)) != null)
            {
                Assert.True(true);
            }
        }

        [Given(@"the user clicks on the Check Box field")]
        public void GivenTheUserClicksOnTheCheckBoxField()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.CheckBoxBy)) != null)
            {
                demoQAElements.CheckBox.Click();
            }
        }

        [When(@"the user clicks on the Home checkbox")]
        public void WhenTheUserClicksOnTheHomeCheckbox()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.CheckBoxHomeBy)) != null)
            {
                demoQAElements.CheckBoxHome.Click();
            }
        }

        [Then(@"all the checkboxes change to ticked")]
        public void ThenAllTheCheckboxesChangeToTicked()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            IWebElement parentElement = driver.FindElement(By.Id("result"));
            ReadOnlyCollection<IWebElement> childElements = parentElement.FindElements(By.XPath("./*"));

            foreach (IWebElement childElement in childElements)
            {
                Console.WriteLine(childElement.Text);
            }

            if (wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("./*"))) != null)
            {
                demoQAElements.CheckBoxHome.Click();
            }
        }

        [Given(@"the user clicks on the Radio Button field")]
        public void GivenTheUserClicksOnTheRadioButtonField()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.RadioButtonBy)) != null)
            {
                demoQAElements.RadioButton.Click();
            }
        }

        [When(@"the user clicks on the Yes radio button")]
        public void WhenTheUserClicksOnTheYesRadioButton()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.RadioButtonYesBy)) != null)
            {
                demoQAElements.RadioButtonYes.Click();
            }
        }

        [Then(@"then the user is informed the Yes button has been selected")]
        public void ThenThenTheUserIsInformedTheYesButtonHasBeenSelected()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.RadioButtonSelectedYesConfirmationBy)) != null)
            {
                demoQAElements.RadioButtonSelectedConfirmation.Click();
            }
        }
    }
}
 