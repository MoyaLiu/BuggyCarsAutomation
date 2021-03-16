using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Helpers
{
    class ConstantHelpers
    {
        public static string Url = "https://buggy.justtestit.org/";

        //ScreenshotPath
        public static string ScreenshotPath = CommonMethods.getCodeDirectory() + @"\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = CommonMethods.getCodeDirectory() + @"\TestReports";



    }
}
