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
        public IWebElement MakeHref => WebDriverExtension.FindElement(_webDriver, By.XPath("//a[contains(@href,'/make/c0bm09bgagshpkqbsuag')]"));
        public IWebElement ModelHref => WebDriverExtension.FindElement(_webDriver, By.XPath("//a[contains(@href,'/model/c0bm09bgagshpkqbsuag|c0bm09bgagshpkqbsuh0')]"));
        public IWebElement OverallHref => WebDriverExtension.FindElement(_webDriver, By.XPath("//a[contains(@href,'/overall')]"));
        public IWebElement LoginNameInput => WebDriverExtension.FindElement(_webDriver, By.Name("login"));
        public IWebElement PasswordInput => WebDriverExtension.FindElement(_webDriver, By.Name("password"));
        public IWebElement WarningTxt => WebDriverExtension.FindElement(_webDriver, By.XPath("//span[@class='label label-warning']"));
        public IWebElement LogoutBtn => WebDriverExtension.FindElement(_webDriver, By.XPath("//a[@class='nav-link'][text()='Logout']"));



        #endregion
        public HomePage(IWebDriver webDriver)
        {
             _webDriver = webDriver;
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
        public void InputText(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }
        public void ClickElement(IWebElement element)
        {
            WebDriverExtension.WaitForClickable(_webDriver, element).Click();
        }
        public void ClickRegister()
        {
            ClickElement(RegisterBtn);
        }
        public void ClickLogin()
        {
            ClickElement(LoginBtn);
        }
        public void ClickLogout()
        {
            ClickElement(LogoutBtn);
        }
        public void ClickMakeHref()
        {
            ClickElement(MakeHref);
        }
        public void ClickModelHref()
        {
            ClickElement(ModelHref);
        }
        public void ClickOverallHref()
        {
            ClickElement(OverallHref);
        }

        public void InputLoginName(String loginName)
        {
            InputText(LoginNameInput, loginName);
        }

        public void InputPassword(String password)
        {
            InputText(PasswordInput, password);
        }
        public bool LogoutDisplayed()
        {
            return ElementIsDisplayed(LogoutBtn);
        }
        public bool LoginDisplayed()
        {
            return ElementIsDisplayed(LoginBtn);
        }
        public bool LogoutIsNotExist()
        {
            if(LogoutBtn == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
