using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MyFramework.Page
{
    /// <summary>
    /// Create WebElements and Methods here (Page Object Model design pattern)
    /// 
    /// Also using Dependancy Injection rather than inheriting from a base class / page
    /// </summary>
    public class DemoQAHomepage
    {
        private readonly WebDriverWait wait;

        public By elementsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[1]");
        public By formsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[2]");
        public By alertsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[3]");
        public By widgetsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[4]");
        public By interactionsCardBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[5]");

        public IWebElement formsCard;
        public IWebElement elementsCard;
        public IWebElement alertsCard;
        public IWebElement widgetsCard;
        public IWebElement interactionsCard;

        public string url = "https://demoqa.com/";


        public DemoQAHomepage(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));

            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.UrlToBe(url));

            formsCard = wait.Until(ExpectedConditions.ElementIsVisible(formsCardBy));
            elementsCard = wait.Until(ExpectedConditions.ElementIsVisible(elementsCardBy));
            alertsCard = wait.Until(ExpectedConditions.ElementIsVisible(alertsCardBy));
            widgetsCard = wait.Until(ExpectedConditions.ElementIsVisible(widgetsCardBy));
            interactionsCard = wait.Until(ExpectedConditions.ElementIsVisible(interactionsCardBy));
        }
    }
}
