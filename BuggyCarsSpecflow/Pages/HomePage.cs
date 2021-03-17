using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class HomePage
    {
        private IWebDriver _webDriver;
        #region FindElement
        public IWebElement RegisterBtn => WebDriverExtension.FindElement(_webDriver, By.XPath("//a[@class='btn btn-success-outline'][text()='Register']"));
        public IWebElement LoginBtn => WebDriverExtension.FindElement(_webDriver, By.XPath("//button[@class='btn btn-success'][text()='Login']"));

        #endregion
        public HomePage(IWebDriver webDriver)
        {
             _webDriver = webDriver;
        }

        public void ClickRegister()
        {
            WebDriverExtension.WaitForClickable(_webDriver, RegisterBtn);
            RegisterBtn.Click();
        }
    }
}
