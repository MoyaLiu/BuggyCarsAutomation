using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;

namespace BuggyCarsSpecflow.Pages
{
    class ProfilePage : BasePage
    {
        public ProfilePage(IWebDriver webDriver) : base(webDriver)
        {
        }
        public IWebElement SaveBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//button[@class='btn btn-default'][text()='Save']"));
        public IWebElement CancelBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='btn'][text()='Cancel']"));
        public IWebElement GenderInput => WebDriverExtension.FindElement(webDriver, By.Id("gender"));
        public IWebElement AgeInput => WebDriverExtension.FindElement(webDriver, By.Id("age"));
        public IWebElement AddressInput => WebDriverExtension.FindElement(webDriver, By.Id("address"));
        public IWebElement PhoneInput => WebDriverExtension.FindElement(webDriver, By.Id("phone"));
        public IWebElement HobbyInput => WebDriverExtension.FindElement(webDriver, By.Id("hobby"));
        public IWebElement SuccessfulAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//div[contains(text(),'The profile has been saved successful')]"));
        public IWebElement ErrorAlert => WebDriverExtension.FindElement(webDriver, By.XPath("//div[contains(text(),'Unknown error')]"));


        public void ClickSave() => ClickElement(SaveBtn);
        public void ClickCancel() => ClickElement(CancelBtn);
        public void InputGender(String gender) => InputText(GenderInput, gender);
        public void InputAge(String age) => InputText(AgeInput, age);
        public void InputAddress(String address) => InputText(AddressInput, address);
        public void InputPhone(String phone) => InputText(PhoneInput, phone);
        public void InputHobby(String hobby) => InputText(HobbyInput, hobby);
        public String SuccefulAlertDisplayed() => AlertDisplayed(SuccessfulAlert);


    }
}
