using MyFramework.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
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
        public By textBoxFieldBy = By.XPath("//*[@id=\"item-0\"]/span");
        public By TextBoxOutputResultBy = By.XPath("//*[@id=\"output\"]/div");
        public By FullNameBy = By.XPath("//*[@id=\"userName\"]");
        public By EmailBy = By.XPath("//*[@id=\"userEmail\"]");
        public By CurrentAddressBy = By.XPath("//*[@id=\"currentAddress\"]");
        public By PermanentAddressBy = By.XPath("//*[@id=\"permanentAddress\"]");
        public By SubmitButtonBy = By.XPath("//*[@id=\"submit\"]");
        public IWebElement TextBoxField => driver.FindElement(textBoxFieldBy);
        public IWebElement TextBoxOutputResult => driver.FindElement(TextBoxOutputResultBy);
        public IWebElement FullName => driver.FindElement(FullNameBy);
        public IWebElement Email => driver.FindElement(EmailBy);
        public IWebElement CurrentAddress => driver.FindElement(CurrentAddressBy);
        public IWebElement PermanentAddress => driver.FindElement(PermanentAddressBy);
        public IWebElement SubmitButton => driver.FindElement(SubmitButtonBy);


        [Given(@"the user is on the Elements page")]
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

            if (wait.Until(ExpectedConditions.ElementIsVisible(textBoxFieldBy)) != null)
            {
                TextBoxField.Click();
                // Url check as url changes
            }
        }

        [When(@"the user enters their details")]
        public void WhenTheUserEntersTheirDetails()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(FullNameBy)) != null)
            {
                FullName.SendKeys("FullName");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(EmailBy)) != null)
            {
                Email.SendKeys("test@gmail.com");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(CurrentAddressBy)) != null)
            {
                CurrentAddress.SendKeys("My Address");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(PermanentAddressBy)) != null)
            {
                PermanentAddress.SendKeys("My Permanent Address");
            }
            if (wait.Until(ExpectedConditions.ElementIsVisible(SubmitButtonBy)) != null)
            {
                SubmitButton.Click();
            }


            Thread.Sleep(5000); // Blocks thread but we can see visually, will use interface for screenshots later
        }

        [Then(@"the user observes a new box appearing below the submit button")]
        public void ThenTheUserObservesANewBoxAppearingBelowTheSubmitButton()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));


            if (wait.Until(ExpectedConditions.ElementIsVisible(TextBoxOutputResultBy)) != null)
            {
                Assert.True(true);
            }
        }

        [Given(@"the user clicks on the Check Box field")]
        public void GivenTheUserClicksOnTheCheckBoxField()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on the Home checkbox")]
        public void WhenTheUserClicksOnTheHomeCheckbox()
        {
            throw new PendingStepException();
        }

        [Then(@"all the checkboxes change to ticked")]
        public void ThenAllTheCheckboxesChangeToTicked()
        {
            throw new PendingStepException();
        }

        [Given(@"the user clicks on the Radio Button field")]
        public void GivenTheUserClicksOnTheRadioButtonField()
        {
            throw new PendingStepException();
        }

        [When(@"the user clicks on the Yes radio button")]
        public void WhenTheUserClicksOnTheYesRadioButton()
        {
            throw new PendingStepException();
        }

        [Then(@"then the user is informed the Yes button has been selected")]
        public void ThenThenTheUserIsInformedTheYesButtonHasBeenSelected()
        {
            throw new PendingStepException();
        }
    }
}
