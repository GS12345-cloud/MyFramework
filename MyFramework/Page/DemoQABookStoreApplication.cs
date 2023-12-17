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
    public class DemoQABookStoreApplication
    {
        private readonly WebDriverWait wait;
        private IWebDriver driver;

        public DemoQABookStoreApplication(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            this.driver = driver;
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.UrlToBe(url));

        }

        /// <summary>
        /// using By locators with XPath (aware id, name is better but starting with XPath for learning purposes).
        /// </summary>
        public By elementsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[1]");
        public By formsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[2]");
        public By alertsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[3]");
        public By widgetsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[4]");
        public By interactionsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[5]");
        /// <summary>
        /// Updated to add the driver.FindElement to the IWebElement
        /// </summary>
        public IWebElement elementsCard => driver.FindElement(elementsCardBy);
        public IWebElement formsCard => driver.FindElement(formsCardBy);
        public IWebElement alertsCard => driver.FindElement(alertsCardBy);
        public IWebElement widgetsCard => driver.FindElement(widgetsCardBy);
        public IWebElement interactionsCard => driver.FindElement(interactionsCardBy);

        public string url = "https://demoqa.com/";

        /// <summary>
        /// Constructor containing IWebElements and a check to avoid NoSuchElementException exception (can use try/catch here)
        /// WebDriverWait better than Thread.Sleep
        /// </summary>
    }
}
