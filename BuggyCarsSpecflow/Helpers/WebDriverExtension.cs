using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Helpers
{
    class WebDriverExtension
    {
        public static IWebElement FindElement(IWebDriver webDriver, By by)
        {
            try
            {
                var webElement = webDriver.FindElement(by);
                return webElement;
            }
            catch (NoSuchElementException ex)
            {
               Console.WriteLine($"Find element{by} failed" + ex.Message);
               return null;
            }
        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                return wait.Until(d => d.FindElement(by));
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException($"Wait for Element {by} failed");
            }
        }

        public static void WaitForClickable(IWebDriver webDriver, By by, int timeOutinSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeOutinSeconds));
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException($"Wait for Click {by} failed");
            }
        }
        public static IWebElement WaitForClickable( IWebDriver driver, IWebElement element, int timeOutinSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                return element;
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException("Waiting for element to be clickable failed");
            }
        }

        public static bool WaitForVisible(IWebDriver webDriver, By by, int timeOutinSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeOutinSeconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine($"Wait for visible {by} failed");
                return false;
            }
        }
        public static IWebElement WaitForDisplayed(IWebDriver driver, By by, int timeOutinSeconds = 5)
        {
            try
            {
                var element = driver.FindElement(by);
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                wait.Until(d => element.Displayed);
                return element;

            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverException($"Wait for element {by}  to be displayed failed");
            }
        }

        public static IWebElement WaitForDisplayed(IWebDriver driver, IWebElement element, int timeOutinSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                wait.Until(d => element.Displayed == true);
                return element;
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException($"Wait for display {element} failed");
            }
        }




    }
}
