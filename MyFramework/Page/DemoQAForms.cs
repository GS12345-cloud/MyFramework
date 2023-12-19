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
    public class DemoQAForms
    {
        private readonly WebDriverWait wait;
        private IWebDriver driver;

        public DemoQAForms(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            this.driver = driver;
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.UrlToBe(url));

        }

        /// <summary>
        /// using By locators with XPath (aware id, name is better but starting with XPath for learning purposes).
        /// </summary>
        public By forenameBy = By.XPath("//*[@id=\"firstName\"]");
        public By surnameBy = By.XPath("//*[@id=\"lastName\"]");
        public By emailBy = By.XPath("//*[@id=\"userEmail\"]");
        public By genderMaleBy = By.XPath("//*[@id=\"gender-radio-1\"]");
        public By genderFemaleBy = By.XPath("//*[@id=\"gender-radio-2\"]");
        public By genderOtherBy = By.XPath("//*[@id=\"gender-radio-3\"]");
        public By mobileBy = By.XPath("//*[@id=\"userNumber\"]");
        public By dateOfBirthBy = By.XPath("//*[@id=\"dateOfBirthInput\"]");
        public By subjectsBy = By.XPath("//*[@id=\"subjectsContainer\"]/div/div[1]");
        public By hobbiesSportsBy = By.XPath("//*[@id=\"hobbiesWrapper\"]/div[2]/div[1]/label");
        public By hobbiesReadingBy = By.XPath("//*[@id=\"hobbiesWrapper\"]/div[2]/div[2]/label");
        public By hobbiesMusicBy = By.XPath("//*[@id=\"hobbiesWrapper\"]/div[2]/div[3]/label");
        /// <summary>
        /// Updated to add the driver.FindElement to the IWebElement
        /// </summary>
        public IWebElement ForenameElement => driver.FindElement(forenameBy);
        public IWebElement SurnameElement => driver.FindElement(surnameBy);
        public IWebElement EmailElement => driver.FindElement(emailBy);
        public IWebElement GenderMaleElement => driver.FindElement(genderMaleBy);
        public IWebElement GenderFemaleElement => driver.FindElement(genderFemaleBy);
        public IWebElement GenderOtherElement => driver.FindElement(genderOtherBy);
        public IWebElement MobileElement => driver.FindElement(mobileBy);
        public IWebElement DateOfBirthElement => driver.FindElement(dateOfBirthBy);
        public IWebElement SubjectsElement => driver.FindElement(subjectsBy);
        public IWebElement HobbiesSportsElement => driver.FindElement(hobbiesSportsBy);
        public IWebElement HobbiesReadingElement => driver.FindElement(hobbiesReadingBy);
        public IWebElement HobbiesMusicElement => driver.FindElement(hobbiesMusicBy);


        public string url = "https://demoqa.com/";

        /// <summary>
        /// Constructor containing IWebElements and a check to avoid NoSuchElementException exception (can use try/catch here)
        /// WebDriverWait better than Thread.Sleep
        /// </summary>
    }
}
