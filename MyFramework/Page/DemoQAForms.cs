using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SkiaSharp;
using System.Drawing;
using System.IO;

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
        //public By consentButtonBy = By.XPath("/html/body/div[3]/div[2]/div[1]/div[2]/div[2]/button[1]");
        //public IWebElement consentButton => driver.FindElement(consentButtonBy);

        /// <summary>
        /// Constructor containing IWebElements and a check to avoid NoSuchElementException exception (can use try/catch here)
        /// WebDriverWait better than Thread.Sleep as doesnt block the thread
        /// </summary>
        /// 
        public DemoQAForms(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            this.driver = driver;
            driver.Navigate().GoToUrl(url);
            wait.Until(ExpectedConditions.UrlToBe(url));
            //consentButton.Click(); // Cookies consent button
        }

        /// <summary>
        /// using By locators with XPath (aware id, name is better but starting with XPath for learning purposes).
        /// </summary>
        public By forenameBy = By.XPath("//*[@id=\"firstName\"]");
        public By surnameBy = By.XPath("//*[@id=\"lastName\"]");
        public By emailBy = By.XPath("//*[@id=\"userEmail\"]");
        public By genderMaleBy = By.XPath("//*[@id=\"genterWrapper\"]/div[2]/div[1]/label"); 
        public By genderFemaleBy = By.XPath("//*[@id=\"gender-radio-2\"]");
        public By genderOtherBy = By.XPath("//*[@id=\"gender-radio-3\"]");
        public By mobileBy = By.XPath("//*[@id=\"userNumber\"]");
        public By dateOfBirthFieldBy = By.XPath("//*[@id=\"dateOfBirthInput\"]");
        public By subjectsFieldBy = By.XPath("//*[@id=\"subjectsContainer\"]");
        public By subjectsListDropdownMenuBy = By.XPath("//*[@id=\"subjectsContainer\"]/div/div[1]");
        public By hobbiesSportsBy = By.XPath("//*[@id=\"hobbies-checkbox-1\"]");
        public By hobbiesReadingBy = By.XPath("//*[@id=\"hobbies-checkbox-2\"]");
        public By hobbiesMusicBy = By.XPath("//*[@id=\"hobbiesWrapper\"]/div[2]/div[3]/label");
        public By pictureBy = By.XPath("//*[@id=\"uploadPicture\"]");
        public By currentAddressBy = By.XPath("//*[@id=\"currentAddress\"]");
        public By uploadPictureBy = By.XPath("//*[@id=\"uploadPicture\"]");
        public By submitButtonBy = By.XPath("//*[@id=\"submit\"]");
        public By formSubmitSuccessBy = By.XPath("//*[@id=\"closeLargeModal\"]");

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
        public IWebElement DateOfBirthFieldElement => driver.FindElement(dateOfBirthFieldBy);
        public IWebElement SubjectsFieldElement => driver.FindElement(subjectsFieldBy);
        public IWebElement SubjectsListDropdownMenuElement => driver.FindElement(subjectsListDropdownMenuBy);
        public IWebElement HobbiesSportsElement => driver.FindElement(hobbiesSportsBy);
        public IWebElement HobbiesReadingElement => driver.FindElement(hobbiesReadingBy);
        public IWebElement HobbiesMusicElement => driver.FindElement(hobbiesMusicBy);
        public IWebElement PictureElement => driver.FindElement(pictureBy);
        public IWebElement CurrentAddressElement => driver.FindElement(currentAddressBy);
        public IWebElement SubmitElement => driver.FindElement(submitButtonBy);
        public IWebElement FormSubmitSuccess => driver.FindElement(formSubmitSuccessBy);



        public string url = "https://demoqa.com/";


        /// <summary>
        /// Using SkiaSharp API as Image/Bitmap no longer supports cross-platforms with System.Drawing.Common no longer supported or recommended
        /// </summary>
        /// <returns></returns>
        /// 
        public static SKImage LoadImage(string imagePath)
        {
            // Load the image from the file into an SKBitmap
            using var stream = new SKFileStream(imagePath);
            using var skBitmap = SKBitmap.Decode(stream);
            // Convert the SKBitmap to SKImage
            SKImage skImage = SKImage.FromBitmap(skBitmap);
            // Return the SKImage
            return skImage;
        }

        public bool IsSubjectChoiceDropdownVisible()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(subjectsFieldBy).Click();

            return wait.Until(ExpectedConditions.ElementIsVisible(subjectsListDropdownMenuBy)) != null;
        }


        /// <summary>
        /// Using Actions here where if the object is more complicated to interact with such as dropdown menus etc we would use this API
        /// </summary>
        public void InteractWithDropdown(IWebElement element)
        {

            Actions actions = new Actions(driver);

            actions.MoveToElement(element);
            Thread.Sleep(2000);
            actions.DoubleClick();
            Thread.Sleep(2000);
            actions.SendKeys(element, "English");
            Thread.Sleep(2000);
            actions.SendKeys(element, Keys.Enter);
            Thread.Sleep(2000);
        }
    }
}
