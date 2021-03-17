using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;

namespace BuggyCarsSpecflow.Pages
{
    class LoginPage : BasePage
    {
        #region FindElement
        public IWebElement LoginBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//button[@class='btn btn-success'][text()='Login']"));
        public IWebElement LoginNameInput => WebDriverExtension.FindElement(webDriver, By.Name("login"));
        public IWebElement PasswordInput => WebDriverExtension.FindElement(webDriver, By.Name("password"));
        public IWebElement WarningTxt => WebDriverExtension.FindElement(webDriver, By.XPath("//span[@class='label label-warning']"));
        public IWebElement LogoutBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='nav-link'][text()='Logout']"));
        #endregion

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public void ClickLogin()
        {
            ClickElement(LoginBtn);
        }
        public void ClickLogout()
        {
            ClickElement(LogoutBtn);
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
            if (LogoutBtn == null)
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
