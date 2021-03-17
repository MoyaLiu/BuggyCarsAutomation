using BuggyCarsSpecflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.SpecFlowSteps.HomePagesSteps
{
    [Binding]
    public sealed class LoginSteps
    {
        LoginPage loginPage = null;
        IWebDriver webDriver = null;

        public LoginSteps(IWebDriver driver)
        {
            webDriver = driver;
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"I enter '(.*)' and '(.*)'")]
        public void GivenIEnterAnd(string loginName, string password)
        {
            loginPage.InputLoginName(loginName);
            loginPage.InputPassword(password);
        }

        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I login successfully")]
        public void ThenILoginSuccessfully()
        {
            Assert.IsTrue(loginPage.LogoutDisplayed());
        }

        [Then(@"I login failed")]
        public void ThenILoginFailed()
        {
            Assert.IsTrue(loginPage.LogoutIsNotExist());
        }

        [When(@"I click Logout")]
        public void WhenIClickLogout()
        {
            loginPage.ClickLogout();
        }

        [Then(@"I logout successfully")]
        public void ThenILogoutSuccessfully()
        {
            Assert.IsTrue(loginPage.LoginDisplayed());
        }


    }
}
