using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Security.Policy;

namespace MyFramework.Page
{
    /// <summary>
    /// Create IWebElements and Methods here (Page Object Model design pattern)
    /// 
    /// Also using Dependancy Injection rather than inheriting from a base class / page
    /// </summary>
    public class DemoQAElements
    {
        private readonly WebDriverWait wait;
        private IWebDriver driver;
        public static string url = "https://demoqa.com/elements";

        public DemoQAElements(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            this.driver = driver;
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.UrlToBe(url));
        }

        public By textBoxFieldBy = By.XPath("//*[@id=\"item-0\"]/span");
        public By TextBoxOutputResultBy = By.XPath("//*[@id=\"output\"]/div");
        public By FullNameBy = By.XPath("//*[@id=\"userName\"]");
        public By EmailBy = By.XPath("//*[@id=\"userEmail\"]");
        public By CurrentAddressBy = By.XPath("//*[@id=\"currentAddress\"]");
        public By PermanentAddressBy = By.XPath("//*[@id=\"permanentAddress\"]");
        public By SubmitButtonBy = By.XPath("//*[@id=\"submit\"]");
        public By CheckBoxBy = By.XPath("//*[@id=\"item-1\"]/span");
        public By CheckBoxHomeBy = By.XPath("//*[@id=\"tree-node\"]/ol/li/span/label");
        public By RadioButtonBy = By.XPath("//*[@id=\"item-2\"]/span");
        public By RadioButtonYesBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/div[2]/label");
        public By RadioButtonSelectedYesConfirmationBy = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/p/span");

        public By WebTablesBy = By.XPath("//*[@id=\"item-3\"]");
        public By ButtonsBy = By.XPath("//*[@id=\"item-4\"]");
        public By LinksBy = By.XPath("//*[@id=\"item-5\"]");
        public By BrokenLinksImagesBy = By.XPath("//*[@id=\"item-6\"]");
        public By UploadAndDownloadBy = By.XPath("//*[@id=\"item-7\"]");
        public By DynamicPropertiesBy = By.XPath("//*[@id=\"item-8\"]");

        public By AddButtonBy = By.Id("addNewRecordButton");

        public By RegistrationFormFirstName = By.Id("firstName");
        public By RegistrationFormLastName = By.Id("lastName");
        public By RegistrationFormEmail = By.Id(" userEmail");
        public By RegistrationFormAge = By.Id("addNewRecordButton");
        public By RegistrationFormSalary = By.Id("addNewRecordButton");
        public By RegistrationFormDepartment = By.Id("addNewRecordButton");

        public IWebElement TextBoxField => driver.FindElement(textBoxFieldBy);
        public IWebElement TextBoxOutputResult => driver.FindElement(TextBoxOutputResultBy);
        public IWebElement FullName => driver.FindElement(FullNameBy);
        public IWebElement Email => driver.FindElement(EmailBy);
        public IWebElement CurrentAddress => driver.FindElement(CurrentAddressBy);
        public IWebElement PermanentAddress => driver.FindElement(PermanentAddressBy);
        public IWebElement SubmitButton => driver.FindElement(SubmitButtonBy);
        public IWebElement CheckBox => driver.FindElement(CheckBoxBy);
        public IWebElement CheckBoxHome => driver.FindElement(CheckBoxHomeBy);
        public IWebElement RadioButton => driver.FindElement(RadioButtonBy);
        public IWebElement RadioButtonYes => driver.FindElement(RadioButtonYesBy);
        public IWebElement RadioButtonSelectedConfirmation => driver.FindElement(RadioButtonSelectedYesConfirmationBy);
        public IWebElement WebTables => driver.FindElement(WebTablesBy);
        public IWebElement Buttons => driver.FindElement(ButtonsBy);
        public IWebElement Links => driver.FindElement(LinksBy);
        public IWebElement BrokenLinksImages => driver.FindElement(BrokenLinksImagesBy);
        public IWebElement UploadAndDownload => driver.FindElement(UploadAndDownloadBy);
        public IWebElement DynamicProperties => driver.FindElement(DynamicPropertiesBy);
        public IWebElement AddButton => driver.FindElement(AddButtonBy);


    }
}
