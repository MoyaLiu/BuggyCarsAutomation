using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class OverallPage : BasePage
    {
        public OverallPage(IWebDriver webDriver) : base(webDriver) { }

        #region FindElement
        public IWebElement PrevirousPageBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='btn disabled'][text()='«']"));
        public IWebElement NextPageBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='btn'][text()='»']"));
        public IWebElement PageNumericTxt => WebDriverExtension.FindElement(webDriver, By.XPath("//a[@class='btn' and text()='»']//ancestor::div[1]"));
        #endregion

        public String getPageNumericTxt() => PageNumericTxt.Text.Trim();
        public void ClickNextPageBtn() => ClickElement(NextPageBtn);
        public bool NextPageBtnIsDisabled() => NextPageBtn.GetAttribute("class").Contains("disabled");
    }
}
