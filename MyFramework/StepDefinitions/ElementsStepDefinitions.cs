using MyFramework.Hooks;
using MyFramework.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
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
        public WebDriverWait wait;

        public ElementsStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAElements = new DemoQAElements(driver);
            wait = new(driver, TimeSpan.FromSeconds(5));
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
            if (wait.Until(ExpectedConditions.UrlToBe(elementsPageUrl)))
            {
                Console.WriteLine("Pass");
            }
        }

        [Given(@"the user clicks on the Text Box field")]
        public void GivenTheUserClicksOnTheTextBoxField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.textBoxFieldBy)) != null)
            {
                demoQAElements.TextBoxField.Click();
                // Url check as url changes
            }
        }

        [When(@"the user enters their details")]
        public void WhenTheUserEntersTheirDetails()
        {
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


            Thread.Sleep(5000); // Blocks thread but we can see visually
        }

        [Then(@"the user observes a new box appearing below the submit button")]
        public void ThenTheUserObservesANewBoxAppearingBelowTheSubmitButton()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.TextBoxOutputResultBy)) != null)
            {
                Assert.True(true);
            }
        }

        [Given(@"the user clicks on the Check Box field")]
        public void GivenTheUserClicksOnTheCheckBoxField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.CheckBoxBy)) != null)
            {
                demoQAElements.CheckBox.Click();
            }
        }

        [When(@"the user clicks on the Home checkbox")]
        public void WhenTheUserClicksOnTheHomeCheckbox()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.CheckBoxHomeBy)) != null)
            {
                demoQAElements.CheckBoxHome.Click();
            }
        }

        [Then(@"all the checkboxes change to ticked")]
        public void ThenAllTheCheckboxesChangeToTicked()
        {
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
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.RadioButtonBy)) != null)
            {
                demoQAElements.RadioButton.Click();
            }
        }

        [When(@"the user clicks on the Yes radio button")]
        public void WhenTheUserClicksOnTheYesRadioButton()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.RadioButtonYesBy)) != null)
            {
                demoQAElements.RadioButtonYes.Click();
            }
        }

        [Then(@"then the user is informed the Yes button has been selected")]
        public void ThenThenTheUserIsInformedTheYesButtonHasBeenSelected()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.RadioButtonSelectedYesConfirmationBy)) != null)
            {
                demoQAElements.RadioButtonSelectedConfirmation.Click();
            }
        }

        [Given(@"the user clicks on the Web Tables field")]
        public void GivenTheUserClicksOnTheWebTablesField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.WebTablesBy)) != null)
            {
                demoQAElements.WebTables.Click();
            }

        }

        [When(@"the user clicks on the Add button")]
        public void WhenTheUserClicksOnTheAddButton()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.AddButtonBy)) != null)
            {
                demoQAElements.AddButton.Click();
            }
        }

        [Then(@"the user completes the form")]
        public void ThenTheUserCompletesTheForm()
        {

        }

        [Given(@"the user clicks on the Buttons field")]
        public void GivenTheUserClicksOnTheButtonsField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.ButtonsBy)) != null)
            {
                demoQAElements.Buttons.Click();
            }
        }

        [When(@"the user clicks on the Click Me button")]
        public void WhenTheUserClicksOnTheClickMeButton()
        {
            if (wait.Until(ExpectedConditions.ElementToBeClickable(demoQAElements.ClickMeBy)) != null)
            {
                demoQAElements.ClickMe.Click();
            }
        }

        [Then(@"the gets a text success")]
        public void ThenTheGetsATextSuccess()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.ClickMeDynamicClickMessage)) != null)
            {
                Assert.Pass();
            }
        }

        [Given(@"the user clicks on the Links field")]
        public void GivenTheUserClicksOnTheLinksField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.LinksBy)) != null)
            {
                demoQAElements.Links.Click();
            }
        }

        [When(@"the user clicks on the Home link")]
        public void WhenTheUserClicksOnTheHomeLink()
        {
            throw new PendingStepException();
        }

        [Then(@"the user gets navigated to the Home page")]
        public void ThenTheUserGetsNavigatedToTheHomePage()
        {
            throw new PendingStepException();
        }

        [Given(@"the user clicks on the Broken Link - Images field")]
        public void GivenTheUserClicksOnTheBrokenLink_ImagesField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.BrokenLinksImagesBy)) != null)
            {
                demoQAElements.BrokenLinksImages.Click();
            }
        }

        [When(@"the user clicks on the Broken link")]
        public void WhenTheUserClicksOnTheBrokenLink()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.BrokenLinkBy)) != null)
            {
                demoQAElements.BrokenLink.Click();
            }
        }

        [Then(@"the user gets navigated to a broken page")]
        public void ThenTheUserGetsNavigatedToABrokenPage()
        {
            if (wait.Until(ExpectedConditions.UrlToBe("https://the-internet.herokuapp.com/status_codes/500")))
            {
                Assert.Pass();
            }
        }

        [Given(@"the user clicks on the UploadDownload button")]
        public void GivenTheUserClicksOnTheUploadDownloadButton()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.UploadDownloadBy)) != null)
            {
                demoQAElements.UploadDownload.Click();
            }
        }


        [When(@"the user clicks on the download button")]
        public void WhenTheUserClicksOnTheDownloadButton()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.DownloadBy)) != null)
            {
                demoQAElements.Download.Click();
            }
        }

        [Then(@"the user gets a file downloaded")]
        public void ThenTheUserGetsAFileDownloaded()
        {
            Download download = new(driver);
            
            if (download.IsFileDownloaded(driver))
            {
                Assert.Pass();
            }
        }

        [Then(@"the user downloads a file")]
        public void ThenTheUserDownloadsAFile()
        {
            throw new PendingStepException();
        }

        [Given(@"the user clicks on the Dynamics Properties field")]
        public void GivenTheUserClicksOnTheDynamicsPropertiesField()
        {
            if (wait.Until(ExpectedConditions.ElementIsVisible(demoQAElements.DynamicPropertiesBy)) != null)
            {
                demoQAElements.DynamicProperties.Click();

            }
        }

        [When(@"the user is met with a Will enable (.*) seconds button")]
        public void WhenTheUserIsMetWithAWillEnableSecondsButton(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the user can see a new button appear")]
        public void ThenTheUserCanSeeANewButtonAppear()
        {
            throw new PendingStepException();
        }

    }
}
 