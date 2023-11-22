using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Data;
using System.Runtime.CompilerServices;

namespace MyFramework
{
    public class GoogleSearchPage
    {
        // Web Elements 
        private IWebElement SearchBox => driver.FindElement(By.Name("q"));
        private IWebElement SearchButton => driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));

        private IWebElement AcceptAll => driver.FindElement(By.XPath("//*[@id=\"L2AGLb\"]/div"));

        private readonly IWebDriver driver;

        // Constructor to initialize the driver
        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Page Methods
        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            // Clear Cookies
            AcceptAll.Click();
            Thread.Sleep(10000);
        }

        public void Search(string searchTerm)

        {
            SearchBox.SendKeys(searchTerm);
            SearchButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(10000);
        }
    }
}
