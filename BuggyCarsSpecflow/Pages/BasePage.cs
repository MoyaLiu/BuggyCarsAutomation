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
        public bool ElementIsDisplayed(IWebElement element) => element.Displayed;
        public String AlertDisplayed(IWebElement element) => WebDriverExtension.WaitForDisplayed(webDriver, element).Text;
        public void InputText(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }
        public void ClickElement(IWebElement element) => WebDriverExtension.WaitForClickable(webDriver, element).Click();
    }
}
