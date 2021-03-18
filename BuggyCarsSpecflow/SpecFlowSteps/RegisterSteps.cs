using BuggyCarsSpecflow.Helpers;
using BuggyCarsSpecflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.SpecFlowSteps
{
    [Binding]
    public class RegisterSteps
    {

        RegisterPage registerPage = null;
        IWebDriver webDriver = null;

        public RegisterSteps(IWebDriver driver)
        {
            webDriver = driver;
            registerPage = new RegisterPage(webDriver);
        }

        [When(@"I click on the Cancel button")]
        public void WhenIClickOnTheCancelButton()
        {
            registerPage.ClickCancel();
        }

        [Then(@"I should be navigate to Home page")]
        public void ThenIShouldBeNavigateToHomePage()
        {
            Assert.AreEqual(ConstantHelpers.HomePageUrl, webDriver.Url);
        }

        [Given(@"I enter data '(.*)','(.*)','(.*)', '(.*)' and '(.*)'")]
        public void GivenIEnterDataAnd(string login, string firstName, string lastName, string password, string confirmPassword)
        {
            registerPage.InputLoginName(login + CommonMethods.getRandomNumber().ToString());
            registerPage.InputFirstName(firstName);
            registerPage.InputlastName(lastName);
            registerPage.InputPassword(password);
            registerPage.InputConfirmPassword(confirmPassword);
        }

        [When(@"I click on the Register below")]
        public void WhenIClickOnTheRegisterBelow()
        {
            registerPage.ClickRegister();
        }

        [Then(@"The '(.*)' is displayed")]
        public void ThenTheIsDisplayed(string successfulMessage)
        {
            Assert.AreEqual(successfulMessage, registerPage.RegistSuccessfulAlertDisplayed());
        }

        [Then(@"The '(.*)' displayed")]
        public void ThenTheDisplayed(string errormessage)
        {
            Assert.IsTrue(registerPage.PasswordLenthWrongAlertDisplayed().Contains(errormessage));
        }








    }
}
