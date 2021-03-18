using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;

namespace BuggyCarsSpecflow.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        #region FindElement
        public IWebElement LoginBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//button[@class='btn btn-success'][text()='Login']"));
        public IWebElement LoginNameInput => WebDriverExtension.FindElement(webDriver, By.Name("login"));
        public IWebElement PasswordInput => WebDriverExtension.FindElement(webDriver, By.Name("password"));
        public IWebElement WarningTxt => WebDriverExtension.FindElement(webDriver, By.XPath("//span[@class='label label-warning']"));
        public IWebElement LogoutBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='nav-link'][text()='Logout']"));
        #endregion

        public void ClickLogin() => ClickElement(LoginBtn);
        public void ClickLogout() => ClickElement(LogoutBtn);
        public void InputLoginName(String loginName) => InputText(LoginNameInput, loginName);
        public void InputPassword(String password) => InputText(PasswordInput, password);
        public bool LogoutDisplayed() => ElementIsDisplayed(LogoutBtn);
        public bool LoginDisplayed() => ElementIsDisplayed(LoginBtn);
        public bool LogoutIsNotExist() => LogoutBtn == null;
        public void Login()
        {
            InputLoginName("moya");
            InputPassword("1122qqWW~");
            ClickLogin();
        }
    }
}
