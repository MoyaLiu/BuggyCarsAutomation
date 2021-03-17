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
    }
}
