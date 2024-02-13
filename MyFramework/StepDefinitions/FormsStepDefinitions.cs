using MyFramework.Hooks;
using MyFramework.Page;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Drawing;
using TechTalk.SpecFlow;
using SkiaSharp;
using static System.Net.WebRequestMethods;
using OpenQA.Selenium.DevTools.V117.Input;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class FormsStepDefinitions
    {
        public Person.GenderChoice male = Person.GenderChoice.Male;
        public string dateOfBirth = DateTime.Now.ToString("dd MMM yyyy");
        public Person.HobbiesChoice hobbies = Person.HobbiesChoice.Music;

        // only supported on windows but for now its fine, we can change this later and is now more of a PoC to ensure Person class is working with the forms
        

        private readonly IWebDriver driver;
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
            driver.Url = "https://demoqa.com/automation-practice-form";
            driver.Navigate();
        }

        [When(@"the user completes the student registration form")]
        public void WhenTheUserCompletesTheStudentRegistrationForm()
        {
            SKImage image = DemoQAForms.LoadImage(@"C:\Users\giwin\Pictures\image.jpg");

            Person person = new("John", "Smith", "Address Here", "myemail@gmail.com", male, 07782425511, dateOfBirth, "English", hobbies,
            image, "Current Address Here");

            /// Can combine all these into a List<IWebElement> collection in a method with a parameter



            demoQAForms.ForenameElement.SendKeys(person.Forename);
            Thread.Sleep(500);
            demoQAForms.SurnameElement.SendKeys(person.Surname);
            Thread.Sleep(500);
            demoQAForms.EmailElement.SendKeys(person.EmailAddress);
            Thread.Sleep(500);
            // use method in main page to choose gender choices, to interact with the correct web element
            demoQAForms.GenderMaleElement.Click();
            Thread.Sleep(500);
            demoQAForms.MobileElement.SendKeys(person.Mobile.ToString());
            Thread.Sleep(500);
            //demoQAForms.DateOfBirthElement.SendKeys(Keys.Control + "a");
            //demoQAForms.DateOfBirthElement.SendKeys(Keys.Delete);
            Thread.Sleep(500);
            demoQAForms.DateOfBirthFieldElement.Click();
            Thread.Sleep(500);
            demoQAForms.SubjectsFieldElement.Click();
            Thread.Sleep(2000);
            Actions actions = new(driver);
            driver.FindElement(By.XPath("//*[@id=\"subjectsContainer\"]/div/div[1]")).Click();
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"subjectsContainer\"]/div/div[1]"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"subjectsInput\"]"))).SendKeys("English");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"subjectsInput\"]"))).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            //var target = driver.FindElement(By.XPath("//*[@id=\"subjectsContainer\"]/div/div[1]"));

            /*
            target.SendKeys("English");
            actions
           .Click(driver.FindElement(By.XPath("//*[@id=\"subjectsContainer\"]/div/div[1]")))  // Click to focus on the input field
           .SendKeys("English") // Type the desired text
           .Build()             // Build the sequence of actions
           .Perform();          // Perform the actions
            //wait.Until(ExpectedConditions.ElementExists(By.XPath(demoQAForms.SubjectsListDropdownMenuElement.Text)));

            demoQAForms.SubjectsListDropdownMenuElement.SendKeys("");
            demoQAForms.SubjectsListDropdownMenuElement.SendKeys("English");
*/
            /* Actions actions = new Actions(driver);
             By userForm = By.XPath("//*[@id=\"subjectsContainer\"]");
             IWebElement element = driver.FindElement(userForm);
             actions.MoveToElement(demoQAForms.SubjectsFieldElement);
             Thread.Sleep(2000);
             actions.DoubleClick();
             Thread.Sleep(2000);
             actions.SendKeys(element, "English");
             Thread.Sleep(2000);
             actions.SendKeys(element, Keys.Enter);
             Thread.Sleep(2000);*/

            demoQAForms.HobbiesMusicElement.Click();
            Thread.Sleep(2000);
            // SendKeys appears to support standard upload pop-up dialogs
            // HTML Tag is Input so supports directly sending the path, nothing extra needed
            demoQAForms.PictureElement.SendKeys(@"C:\Users\giwin\Pictures\image.jpg");

            Thread.Sleep(2000);
            demoQAForms.CurrentAddressElement.SendKeys(person.CurrentAddress);

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"react-select-3-input\"]"))).SendKeys("NCR");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"react-select-3-input\"]"))).SendKeys(Keys.Tab);
            Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"react-select-4-input\"]"))).SendKeys("Delhi");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"react-select-4-input\"]"))).SendKeys(Keys.Tab);
            Thread.Sleep(2000);
            // It's not actually possible to see the button in Chrome due to the button being covered by an advertisment. Will leave this for now
            // It's not possible for the user to click on the Submit as it's outside the view.
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"submit\"]"))).SendKeys(Keys.Enter);

        }


        [Then(@"the user submits their details")]
        public void ThenTheUserSubmitsTheirDetails()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
            // It's not actually possible to see the button in Chrome due to the button being covered by an advertisment. Will leave this for now
            // It's not possible for the user to click on the Submit as it's outside the view.
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"submit\"]"))).SendKeys(Keys.Enter);
            // //*[@id="closeLargeModal"]
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"closeLargeModal\"]"))).Click();
        }
    }
}
