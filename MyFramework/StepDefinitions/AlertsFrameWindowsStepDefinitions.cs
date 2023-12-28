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



        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
