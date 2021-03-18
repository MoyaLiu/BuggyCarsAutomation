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
    public sealed class ProfilePageSteps
    {
        LoginPage loginPage = null;
        IWebDriver webDriver = null;
        ProfilePage profilePage = null;

        public ProfilePageSteps(IWebDriver driver)
        {
            webDriver = driver;
            loginPage = new LoginPage(webDriver);
            profilePage = new ProfilePage(webDriver);
        }
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            loginPage.Login();
        }

        [Then(@"I should be navigate to the Profile page")]
        public void ThenIShouldBeNavigateToTheProfilePage()
        {
            Assert.AreEqual(ConstantHelpers.ProfilePageUrl, webDriver.Url);
        }

        [When(@"I input '(.*)','(.*)','(.*)','(.*)' and'(.*)'")]
        public void WhenIInputAnd(string gender, string age, string address, string phone, string hobby)
        {
            profilePage.InputGender(gender);
            profilePage.InputAge(age);
        }
        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            profilePage.ClickSave();
        }

        [Then(@"The '(.*)' on profile displayed")]
        public void ThenTheOnProfileDisplayed(string successfulMessage)
        {
            Assert.AreEqual(successfulMessage, profilePage.SuccefulAlertDisplayed());
        }

        [When(@"I click on Cancel button")]
        public void WhenIClickOnCancelButton()
        {
            profilePage.ClickCancel();
        }

    }
}
