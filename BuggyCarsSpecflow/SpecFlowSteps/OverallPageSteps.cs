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
    public sealed class OverallPageSteps
    {
        OverallPage overallPage = null;
        IWebDriver webDriver = null;

        public OverallPageSteps(IWebDriver driver)
        {
            webDriver = driver;
            overallPage = new OverallPage(webDriver);
        }
        [Given(@"Navigate to the Overall Rating page")]
        public void GivenNavigateToTheOverallRatingPage()
        {
            webDriver.Navigate().GoToUrl(ConstantHelpers.OverallPageUrl);
        }

        [When(@"click next page button to the last page")]
        public void WhenClickNextPageButtonToTheLastPage()
        {
            String[] PageTxt = overallPage.getPageNumericTxt().Split(" ");
            int CurrentPageNumber = Convert.ToInt32(PageTxt[3]);
            int LastPageNumber = Convert.ToInt32(PageTxt[5]);
            for (int i = 1; i <= LastPageNumber; i++)
            {
                overallPage.ClickNextPageBtn();
            }          
        }

        [Then(@"Next page button should be disabled in the last page")]
        public void ThenNextPageButtonShouldBeDisabledInTheLastPage()
        {
            Assert.IsTrue(overallPage.NextPageBtnIsDisabled());
        }

        [When(@"click the last one car in the list")]
        public void WhenClickTheLastOneCarInTheList()
        {
            overallPage.ClickLastCarItem();
        }


        [Then(@"Navigate to the car details page")]
        public void ThenNavigateToTheCarDetailsPage()
        {
            Assert.IsTrue(webDriver.Url.Contains(ConstantHelpers.modelPageUrlPrefix));
        }


    }
}
