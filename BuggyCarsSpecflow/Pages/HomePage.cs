using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;

namespace BuggyCarsSpecflow.Pages
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver) { }

        #region FindElement
        public IWebElement RegisterBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='btn btn-success-outline'][text()='Register']"));
        public IWebElement MakeHref => WebDriverExtension.FindElement(webDriver, By.XPath("//a[contains(@href,'/make/c0bm09bgagshpkqbsuag')]"));
        public IWebElement ModelHref => WebDriverExtension.FindElement(webDriver, By.XPath("//a[contains(@href,'/model/c0bm09bgagshpkqbsuag|c0bm09bgagshpkqbsuh0')]"));
        public IWebElement OverallHref => WebDriverExtension.FindElement(webDriver, By.XPath("//a[contains(@href,'/overall')]"));
        public IWebElement ProfileBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='nav-link'][text()='Profile']"));
        #endregion

        public void ClickRegister() => ClickElement(RegisterBtn);
        public void ClickMakeHref() => ClickElement(MakeHref);
        public void ClickModelHref() => ClickElement(ModelHref);
        public void ClickOverallHref() => ClickElement(OverallHref);
        public void ClickProfile() => ClickElement(ProfileBtn);
    }
}
