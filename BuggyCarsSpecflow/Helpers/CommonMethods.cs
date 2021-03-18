using AventStack.ExtentReports;
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace BuggyCarsSpecflow.Helpers
{
    class CommonMethods
    {
        #region reports

        public static string TryToTakeScreenshot(IWebDriver driver)
        {
            var screenshotTaker = driver as ITakesScreenshot;
            try
            {
                var screenshot = screenshotTaker.GetScreenshot();
                var screenshotFilePath = CreateScreenshotFilePath();
                screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                return screenshotFilePath;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private static string CreateScreenshotFilePath()
        {
            var screenshotFileName = "screenshot" + DateTime.Now.ToString("_MM_dd_yyyy_HH-mm") + ".png";
            return Path.Combine(ConstantHelpers.ScreenshotPath, screenshotFileName);
        }

        //ExtentReports


        public static ExtentReports extent;
        public static void ExtentReports()
        {
            ExtentHtmlReporter html = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);
            extent = new ExtentReports();
            html.Config.ReportName = "Buggy Cars Rating Test Report";
            extent.AttachReporter(html);
        }
        #endregion
        public static string getCodeDirectory()
        {
            var filepath = System.AppDomain.CurrentDomain.BaseDirectory;
            return filepath + @"..\..\..\";
        }
        public static int getRandomNumber(int min=0, int max=999)
        {
            return new Random().Next(min, max);
        }

    }
}
