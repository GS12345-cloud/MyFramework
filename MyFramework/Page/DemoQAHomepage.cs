using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public DemoQAHomepage(IWebDriver driver)
        {
            this.driver = driver;
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
