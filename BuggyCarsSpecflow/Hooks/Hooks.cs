using BoDi;
using BuggyCarsSpecflow.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;
        private readonly IObjectContainer objectContainer;
        public Hooks(IObjectContainer container)
        {
            objectContainer = container;
        }
        [BeforeScenario]
        public void Setup()
        {
            driver = Driver.GetDriver();
            objectContainer.RegisterInstanceAs(driver);
            //ExcelLibHelper.PopulateInCollection(CommonMethods.getCodeDirectory() + @"\TestData\Register")
        }
        [AfterScenario]
        public void Teardown()
        {

            string img = CommonMethods.SaveScreenShotClass.SaveScreenshot(driver, "Report");
            //CommonMethods.test.Log(AventStack.ExtentReports.Status.Info, "Snapshot below: " + CommonMethods.test.AddScreenCaptureFromBase64String(img));        
            Driver.Close(driver);
        }
        [AfterFeature]
        public static void GenerateTestReport()
        {
            CommonMethods.ExtentReports();
            CommonMethods.extent.Flush();
        }
    }
}
