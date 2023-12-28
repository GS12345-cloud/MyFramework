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
    public class WidgetsStepDefinitions
    {
        private IWebDriver driver;
        private readonly DemoQAHomepage demoQAHomepage;

        public WidgetsStepDefinitions()
        {
            // Initialize the page object with the WebDriver
            driver = new ChromeDriver();
            demoQAHomepage = new DemoQAHomepage(driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
