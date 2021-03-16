using BuggyCarsSpecflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.Hooks
{
    [Binding]
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            Initialize();
            Console.WriteLine("...........Setup");
            //ExcelLibHelper.PopulateInCollection(CommonMethods.getCodeDirectory() + @"\TestData\Register")
        }
        [AfterScenario]
        public void Teardown()
        {
            CommonMethods.ExtentReports();
            string img = CommonMethods.SaveScreenShotClass.SaveScreenshot(driver, "Report");
            CommonMethods.test.Log(AventStack.ExtentReports.Status.Info, "Snapshot below: " + CommonMethods.test.AddScreenCaptureFromBase64String(img));
            CommonMethods.extent.Flush();
            Close();
            Console.WriteLine("...........Teardown");
        }

    }
}
