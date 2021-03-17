using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;

namespace BuggyCarsSpecflow.Pages
{
    class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver webDriver) : base(webDriver) { }

        #region FindElement
        public IWebElement RegisterBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//button[@class='btn btn-default'][text()='Register']"));
        public IWebElement CancelBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='btn'][text()='Cancel']"));
        public IWebElement LoginInput => WebDriverExtension.FindElement(webDriver, By.Id("username"));
        public IWebElement FirstNameInput => WebDriverExtension.FindElement(webDriver, By.Id("firstName"));
        public IWebElement LastNameInput => WebDriverExtension.FindElement(webDriver, By.Id("lastName"));
        public IWebElement PasswordInput => WebDriverExtension.FindElement(webDriver, By.Id("password"));
        public IWebElement ConfirmPasswordInput => WebDriverExtension.FindElement(webDriver, By.Id("confirmPassword"));
        public IWebElement RegisterSuccessfulAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//div[@class='result alert alert-success']"));
        public IWebElement NoUsernameAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//*[contains(text(),'Login is required')]"));
        public IWebElement NoFirstNameAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//my-register/div/div/form/div[2]/div[contains(text(),'First Name is required')]"));
        public IWebElement NoLastNameAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//my-register/div/div/form/div[3]/div[contains(text(),'Last Name is required')]"));
        public IWebElement NoPasswordAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//my-register/div/div/form/div[4]/div[contains(text(),'Password is required')]"));
        public IWebElement NoUpperLetterInPasswordAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//*[contains(text(),'must have uppercase')]"));
        public IWebElement NoLowerLetterPasswordAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//*[contains(text(),'must have lowercase')]"));
        public IWebElement NoNumericInPasswordAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//*[contains(text(),'must have numeric')]"));
        public IWebElement PasswordLenthWrongAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//*[contains(text(),'Password not long enough')]"));
        public IWebElement PasswordDonotMatchAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//my-register/div/div/form/div[5]/div[contains(text(),'Passwords do not match')]"));
        #endregion

        public void ClickRegister() => ClickElement(RegisterBtn);
        public void ClickCancel() => ClickElement(CancelBtn);
        public void InputLoginName(String loginName) => InputText(LoginInput, loginName);
        public void InputFirstName(String firstName) => InputText(FirstNameInput, firstName);
        public void InputlastName(String lastName) => InputText(LastNameInput, lastName);
        public void InputPassword(String password) => InputText(PasswordInput, password);
        public void InputConfirmPassword(String confirmPassword) => InputText(ConfirmPasswordInput, confirmPassword);
        public String RegistSuccessfulAlertDisplayed() => AlertDisplayed(RegisterSuccessfulAlert);
        public String NoUserNameAlertDisplayed() => AlertDisplayed(NoUsernameAlert);
        public String NoFirstNameAlertDisplayed() => AlertDisplayed(NoFirstNameAlert);
        public String NoLastNameAlertAlertDisplayed() => AlertDisplayed(NoLastNameAlert);
        public String NoUpperLetterInPasswordAlertDisplayed() => AlertDisplayed(NoUpperLetterInPasswordAlert);
        public String PasswordLenthWrongAlertDisplayed() => AlertDisplayed(PasswordLenthWrongAlert);


    }
}
