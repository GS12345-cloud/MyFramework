using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFramework.Page
{
    /// <summary>
    /// Create WebElements and Methods here (Page Object Model design pattern)
    /// 
    /// Also using Dependancy Injection rather than inheriting from a base class / page
    /// </summary>
    public class DemoQAHomepage
    {
        public IWebDriver driver;

        //public IWebElement elementsCard;
        //public IWebElement pageTitle;
        public IWebElement element;


        public DemoQAHomepage(IWebDriver driver)
        {
            this.driver = driver;

            element = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[1]/div/div[2]"));
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void GoTo()
        {
            driver.Url = "https://demoqa.com/";
            driver.Navigate();
        }
    }
}
