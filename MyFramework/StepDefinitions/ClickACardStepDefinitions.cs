using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Xceed.Wpf.Toolkit;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras;
using SeleniumExtras.WaitHelpers;
using System.Text.RegularExpressions;

namespace MyFramework.StepDefinitions
{
    [Binding]
    public class ClickACardStepDefinitions
    {
        public IWebDriver driver;
        public IWebElement element;
        

        public ClickACardStepDefinitions()
        {
            // Initialize the page object with the WebDriver

            driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            element = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[1]/div/div[2]"));
        }


        [Given(@"the user is on the Homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            driver.Navigate();
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.UrlToBe("https://demoqa.com/"));
        }

        [When(@"the user clicks on the Card")]
        public void WhenTheUserClicksOnTheCard()
        {
            element.Click();
        }

        [Then(@"the page navigates to a new page")]
        public void ThenThePageNavigatesToANewPage()
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
            bool url = wait.Until(ExpectedConditions.UrlMatches(new Regex("https://demoqa.com/elements").ToString()));
            Assert.IsTrue(url);
        }
    }
}
