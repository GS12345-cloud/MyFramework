using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFramework.Hooks
{
    public class Download
    {
        ChromeOptions options = new ChromeOptions();

        public Download(IWebDriver driver)
        {

        }

        // Cheap way of checking but it works, also accounts for switching to a different user
        public bool IsFileDownloaded(IWebDriver driver)
        {
            string username = Environment.UserName;
            string directoryPath = $@"C:\Users\{username}\Downloads";
            TimeSpan recentThreshold = TimeSpan.FromMinutes(1);

            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                if (DateTime.Now - File.GetCreationTime(filePath) < recentThreshold)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
