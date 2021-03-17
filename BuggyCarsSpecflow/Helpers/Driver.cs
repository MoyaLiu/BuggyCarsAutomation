using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Helpers
{
    public class Driver
    {
        public static IWebDriver GetDriver()
        {
            var browser = "Chrome";
            IWebDriver driver = null;
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
            }

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Manage().Window.Maximize();

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Fail get driver. " + e);
            }
            return driver;

        }

        //Close the browser
        public static void Close(IWebDriver driver)
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}

