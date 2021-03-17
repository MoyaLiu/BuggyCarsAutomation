using BuggyCarsSpecflow.Helpers;
using BuggyCarsSpecflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.SpecFlowSteps
{
    [Binding]
    public sealed class HomePageSteps
    {

        HomePage homePage = null;
        IWebDriver webDriver = null;

        public HomePageSteps(IWebDriver driver)
        {
            webDriver = driver;
            homePage = new HomePage(webDriver);
        }

        [Given(@"Launch to the Home page")]
        public void GivenLaunchToTheHomePage()
        {
            webDriver.Navigate().GoToUrl(ConstantHelpers.HomePageUrl);
        }

        [Given(@"I click on the Register")]
        public void GivenIClickOnTheRegister()
        {
            homePage.ClickRegister();
        }
        [Then(@"I should be navigate to Register page")]
        public void ThenIShouldBeNavigateToRegisterPage()
        {
            Assert.AreEqual(ConstantHelpers.RegisterPageUrl, webDriver.Url);
        }

        [Given(@"I click on the Profile")]
        public void GivenIClickOnTheProfile()
        {
            homePage.ClickProfile();
        }
        [When(@"I click on the Register")]
        public void WhenIClickOnTheRegister()
        {
            homePage.ClickRegister();
        }

        [When(@"I click on the Popular Make")]
        public void WhenIClickOnThePopularMake()
        {
            homePage.ClickMakeHref();
        }

        [Then(@"I should be navigate to Popular Make page")]
        public void ThenIShouldBeNavigateToPopularMakePage()
        {
            Assert.AreEqual(ConstantHelpers.MakePageUrl, webDriver.Url);
        }

        [When(@"I click on the Popular Model")]
        public void WhenIClickOnThePopularModel()
        {
            homePage.ClickModelHref();
        }

        [Then(@"I should be navigate to Popular Model page")]
        public void ThenIShouldBeNavigateToPopularModelPage()
        {
            Assert.AreEqual(ConstantHelpers.ModelPageUrl, webDriver.Url);
        }

        [When(@"I click on the Overall Rating")]
        public void WhenIClickOnTheOverallRating()
        {
            homePage.ClickOverallHref();
        }

        [Then(@"I should be navigate to Overall Rating page")]
        public void ThenIShouldBeNavigateToOverallRatingPage()
        {
            Assert.AreEqual(ConstantHelpers.OverallPageUrl, webDriver.Url);
        }

    }
}
