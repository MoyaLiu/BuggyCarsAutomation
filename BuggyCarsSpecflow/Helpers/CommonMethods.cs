using AventStack.ExtentReports;
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Helpers
{
    class CommonMethods
    {
        #region reports
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".png");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }

        //ExtentReports


        public static ExtentReports extent;
        public static ExtentTest test;

        public static void ExtentReports()
        {
            ExtentHtmlReporter html = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);
            extent = new ExtentReports();
            extent.AttachReporter(html);
            test = extent.CreateTest("Buggy cars Rating Test", "The report of Buggy cars Rating");
        }
        #endregion
        public static string getCodeDirectory()
        {
            var filepath = System.AppDomain.CurrentDomain.BaseDirectory;
            return filepath + @"..\..\..\";
        }

    }
}
