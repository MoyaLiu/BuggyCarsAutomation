using BuggyCarsSpecflow.Helpers;
using BuggyCarsSpecflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.SpecFlowSteps
{
    [Binding]
    public sealed class CarDetailsSteps
    {
        CarDetailPage carDetailPage = null;
        IWebDriver webDriver = null;
        LoginPage loginPage = null;
        OverallPage overallPage = null;
        RegisterPage registerPage = null;
        String LoginName = null;
        public CarDetailsSteps(IWebDriver driver)
        {
            webDriver = driver;
            carDetailPage = new CarDetailPage(webDriver);
            loginPage = new LoginPage(webDriver);
            overallPage = new OverallPage(webDriver);
            registerPage = new RegisterPage(webDriver);
        }

        [Given(@"I register a new account with '(.*)','(.*)','(.*)', '(.*)' and '(.*)'")]
        public void GivenIRegisterANewAccountWithAnd(string login, string firstName, string lastName, string password, string confirmPassword)
        {
            LoginName = login + CommonMethods.getRandomNumber().ToString();
            webDriver.Navigate().GoToUrl(ConstantHelpers.HomePageUrl);
            webDriver.Navigate().GoToUrl(ConstantHelpers.RegisterPageUrl);
            registerPage.InputLoginName(LoginName);
            registerPage.InputFirstName(firstName);
            registerPage.InputlastName(lastName);
            registerPage.InputPassword(password);
            registerPage.InputConfirmPassword(confirmPassword);
            registerPage.ClickRegister();
        }

        [Given(@"I logged in with '(.*)','(.*)'and go to the Car detail page")]
        public void GivenILoggedInWithAndGoToTheCarDetailPage(string login, string password)
        {
            webDriver.Navigate().GoToUrl(ConstantHelpers.HomePageUrl);
            loginPage.InputLoginName(LoginName);
            loginPage.InputPassword(password);
            loginPage.ClickLogin();
            Thread.Sleep(2000);
            webDriver.Navigate().GoToUrl(ConstantHelpers.OverallPageUrl);
            overallPage.ClickLastCarItem();
        }

        [When(@"I enter the Comment '(.*)'")]
        public void WhenIEnterTheComment(string comment)
        {
            carDetailPage.InputComment(comment);
        }

        [When(@"I click the Vote button")]
        public void WhenIClickTheVoteButton()
        {
            carDetailPage.ClickVoteBtn();
        }

        [Then(@"the car is voted")]
        public void ThenTheCarIsVoted()
        {
            Assert.AreEqual("Thank you for your vote!", carDetailPage.VoteTxtDisplayed());
        }

    }
}
