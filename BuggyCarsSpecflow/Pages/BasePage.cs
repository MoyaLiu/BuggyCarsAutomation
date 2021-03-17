using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class BasePage
    {
        protected readonly IWebDriver webDriver;

        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
        }
        public bool ElementIsDisplayed(IWebElement element)
        {
            if (element.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public String AlertDisplayed(IWebElement element)
        {
            return WebDriverExtension.WaitForDisplayed(webDriver, element).Text;
        }
        public void InputText(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }
        public void ClickElement(IWebElement element)
        {
            WebDriverExtension.WaitForClickable(webDriver, element).Click();
        }
    }
}
