using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class RegisterPage
    {
        IWebDriver _webDriver;
        #region FindElement
        public IWebElement RegisterBtn => WebDriverExtension.FindElement(_webDriver, By.XPath("//button[@class='btn btn-default'][text()='Register']"));
        public IWebElement CancelBtn => WebDriverExtension.FindElement(_webDriver, By.XPath("//a[@class='btn'][text()='Cancel']"));
        public IWebElement LoginInput => WebDriverExtension.FindElement(_webDriver, By.Id("username"));
        public IWebElement FirstNameInput => WebDriverExtension.FindElement(_webDriver, By.Id("firstName"));
        public IWebElement LastNameInput => WebDriverExtension.FindElement(_webDriver, By.Id("lastName"));
        public IWebElement PasswordInput => WebDriverExtension.FindElement(_webDriver, By.Id("password"));
        public IWebElement ConfirmPasswordInput => WebDriverExtension.FindElement(_webDriver, By.Id("confirmPassword"));
        public IWebElement RegisterSuccessfulAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//div[@class='result alert alert-success']"));
        public IWebElement NoUsernameAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//*[contains(text(),'Login is required')]"));
        public IWebElement NoFirstNameAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//my-register/div/div/form/div[2]/div[contains(text(),'First Name is required')]"));
        public IWebElement NoLastNameAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//my-register/div/div/form/div[3]/div[contains(text(),'Last Name is required')]"));
        public IWebElement NoPasswordAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//my-register/div/div/form/div[4]/div[contains(text(),'Password is required')]"));
        public IWebElement NoUpperLetterInPasswordAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//*[contains(text(),'must have uppercase')]"));
        public IWebElement NoLowerLetterPasswordAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//*[contains(text(),'must have lowercase')]"));
        public IWebElement NoNumericInPasswordAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//*[contains(text(),'must have numeric')]"));
        public IWebElement PasswordLenthWrongAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//*[contains(text(),'Password not long enough')]"));
        public IWebElement PasswordDonotMatchAlert => WebDriverExtension.FindElement(_webDriver, By.XPath("//my-register/div/div/form/div[5]/div[contains(text(),'Passwords do not match')]"));
        #endregion
        public RegisterPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void InputText(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }
        public String AlertDisplayed(IWebElement element)
        {
            return WebDriverExtension.WaitForDisplayed(_webDriver, element).Text;
        }
        public void ClickRegister()
        {
            WebDriverExtension.WaitForClickable(_webDriver, RegisterBtn).Click();
        }
        public void ClickCancel()
        {
            WebDriverExtension.WaitForClickable(_webDriver, CancelBtn).Click();
        }
        #region Input
        public void InputLoginName(String loginName)
        {
            InputText(LoginInput, loginName);
        }
        public void InputFirstName(String firstName)
        {
            InputText(FirstNameInput, firstName);
        }
        public void InputlastName(String lastName)
        {
            InputText(LastNameInput, lastName);
        }
        public void InputPassword(String password)
        {
            InputText(PasswordInput, password);
        }
        public void InputConfirmPassword(String confirmPassword)
        {
            InputText(ConfirmPasswordInput, confirmPassword);
        }
        #endregion
        #region Alert
        public String RegistSuccessfulAlertDisplayed()
        {
            return AlertDisplayed(RegisterSuccessfulAlert);
        }
        public String NoUserNameAlertDisplayed()
        {
            return AlertDisplayed(NoUsernameAlert);
        }
        public String NoFirstNameAlertDisplayed()
        {
            return AlertDisplayed(NoFirstNameAlert);
        }
        public String NoLastNameAlertAlertDisplayed()
        {
            return AlertDisplayed(NoLastNameAlert);
        }
        public String NoUpperLetterInPasswordAlertDisplayed()
        {
            return AlertDisplayed(NoUpperLetterInPasswordAlert);
        }
        public String PasswordLenthWrongAlertDisplayed()
        {
            return AlertDisplayed(PasswordLenthWrongAlert);
        }
        #endregion


    }
}
