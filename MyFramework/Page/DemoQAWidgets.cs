using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MyFramework.Page
{
    /// <summary>
    /// Create IWebElements and Methods here (Page Object Model design pattern)
    /// 
    /// Also using Dependancy Injection rather than inheriting from a base class / page
    /// </summary>
    public class DemoQAWidgets
    {
        private readonly WebDriverWait wait;
        private IWebDriver driver;

        public DemoQAWidgets(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            this.driver = driver;
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.UrlToBe(url));

        }


        public string url = "https://demoqa.com/";

        /// <summary>
        /// Constructor containing IWebElements and a check to avoid NoSuchElementException exception (can use try/catch here)
        /// WebDriverWait better than Thread.Sleep
        /// </summary>
    }
}
