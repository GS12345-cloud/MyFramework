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
        public By textBoxFieldBy = By.XPath("//*[@id=\"item-0\"]/span");
        public By TextBoxOutputResultBy = By.XPath("//*[@id=\"output\"]/div");
        public By FullNameBy = By.XPath("//*[@id=\"userName\"]");
        public By EmailBy = By.XPath("//*[@id=\"userEmail\"]");
        public By CurrentAddressBy = By.XPath("//*[@id=\"currentAddress\"]");
        public By PermanentAddressBy = By.XPath("//*[@id=\"permanentAddress\"]");
        public By SubmitButtonBy = By.XPath("//*[@id=\"submit\"]");
        public By CheckBoxBy = By.XPath("//*[@id=\"item-1\"]/span");
        public By CheckBoxHomeBy = By.XPath("//*[@id=\"tree-node\"]/ol/li/span/label");
        public By RadioButtonBy = By.XPath("//*[@id=\"item-2\"]/span");
        public By RadioButtonYesBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/div[2]/label");
        public By RadioButtonSelectedYesConfirmationBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/p/span");
        public IWebElement TextBoxField => driver.FindElement(textBoxFieldBy);
        public IWebElement TextBoxOutputResult => driver.FindElement(TextBoxOutputResultBy);
        public IWebElement FullName => driver.FindElement(FullNameBy);
        public IWebElement Email => driver.FindElement(EmailBy);
        public IWebElement CurrentAddress => driver.FindElement(CurrentAddressBy);
        public IWebElement PermanentAddress => driver.FindElement(PermanentAddressBy);
        public IWebElement SubmitButton => driver.FindElement(SubmitButtonBy);
        public IWebElement CheckBox => driver.FindElement(CheckBoxBy);
        public IWebElement CheckBoxHome => driver.FindElement(CheckBoxHomeBy);
        public IWebElement RadioButton => driver.FindElement(RadioButtonBy);
        public IWebElement RadioButtonYes => driver.FindElement(RadioButtonYesBy);
        public IWebElement RadioButtonSelectedConfirmation => driver.FindElement(RadioButtonSelectedYesConfirmationBy);


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }

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
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(CheckBoxBy)) != null)
            {
                CheckBox.Click();
            }
        }

        [When(@"the user clicks on the Home checkbox")]
        public void WhenTheUserClicksOnTheHomeCheckbox()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(CheckBoxHomeBy)) != null)
            {
                CheckBoxHome.Click();
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
                CheckBoxHome.Click();
            }
        }

        [Given(@"the user clicks on the Radio Button field")]
        public void GivenTheUserClicksOnTheRadioButtonField()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(RadioButtonBy)) != null)
            {
                RadioButton.Click();
            }
        }

        [When(@"the user clicks on the Yes radio button")]
        public void WhenTheUserClicksOnTheYesRadioButton()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));

            if (wait.Until(ExpectedConditions.ElementIsVisible(RadioButtonYesBy)) != null)
            {
                RadioButtonYes.Click();
            }
        }

        [Then(@"then the user is informed the Yes button has been selected")]
        public void ThenThenTheUserIsInformedTheYesButtonHasBeenSelected()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));

            if (wait.Until(ExpectedConditions.ElementIsVisible(RadioButtonSelectedYesConfirmationBy)) != null)
            {
                RadioButtonSelectedConfirmation.Click();
            }
        }
    }
}
 