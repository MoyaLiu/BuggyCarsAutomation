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
        HomePage homePage = null;
        IWebDriver webDriver = null;

        public LoginSteps(IWebDriver driver)
        {
            webDriver = driver;
            homePage = new HomePage(webDriver);
        }

        [Given(@"I enter '(.*)' and '(.*)'")]
        public void GivenIEnterAnd(string loginName, string password)
        {
            homePage.InputLoginName(loginName);
            homePage.InputPassword(password);
        }

        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            homePage.ClickLogin();
        }

        [Then(@"I login successfully")]
        public void ThenILoginSuccessfully()
        {
            Assert.IsTrue(homePage.LogoutDisplayed());
        }

        [Then(@"I login failed")]
        public void ThenILoginFailed()
        {
            Assert.IsTrue(homePage.LogoutIsNotExist());
        }

        [When(@"I click Logout")]
        public void WhenIClickLogout()
        {
            homePage.ClickLogout();
        }

        [Then(@"I logout successfully")]
        public void ThenILogoutSuccessfully()
        {
            Assert.IsTrue(homePage.LoginDisplayed());
        }


    }
}
