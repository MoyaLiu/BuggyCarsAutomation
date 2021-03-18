using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class CarDetailPage : BasePage
    {
        public CarDetailPage(IWebDriver webDriver) : base(webDriver) { }

        #region FindElement
        public IWebElement CommentTextarea => WebDriverExtension.FindElement(webDriver, By.Id("comment"));
        public IWebElement VoteBtn => WebDriverExtension.FindElement(webDriver, By.XPath("//button[@class='btn btn-success']"));
        public IWebElement VoteTxt => WebDriverExtension.FindElement(webDriver, By.XPath("//p[@class='card-text']"));
        #endregion
        public void InputComment(String comment) => InputText(CommentTextarea, comment);
        public void ClickVoteBtn() => ClickElement(VoteBtn);
        public String VoteTxtDisplayed() => AlertDisplayed(VoteTxt);


    }
}
