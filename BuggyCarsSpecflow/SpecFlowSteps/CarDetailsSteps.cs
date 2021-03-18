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
        public CarDetailsSteps(IWebDriver driver)
        {
            webDriver = driver;
            carDetailPage = new CarDetailPage(webDriver);
            loginPage = new LoginPage(webDriver);
            overallPage = new OverallPage(webDriver);
        }

        [Given(@"I have logged in and on the Cardetail page")]
        public void GivenIHaveLoggedInAndOnTheCardetailPage()
        {
            webDriver.Navigate().GoToUrl(ConstantHelpers.HomePageUrl);
            loginPage.Login();
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
