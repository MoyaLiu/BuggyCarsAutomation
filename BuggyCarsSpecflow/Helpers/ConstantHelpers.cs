using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Helpers
{
    class ConstantHelpers
    {
        public static string HomePageUrl = "https://buggy.justtestit.org/";
        public static string RegisterPageUrl = "https://buggy.justtestit.org/register";
        public static string MakePageUrl = "https://buggy.justtestit.org/make/c0bm09bgagshpkqbsuag";
        public static string ModelPageUrl = "https://buggy.justtestit.org/model/c0bm09bgagshpkqbsuag%7Cc0bm09bgagshpkqbsuh0";
        public static string OverallPageUrl = "https://buggy.justtestit.org/overall";
        public static string ProfilePageUrl = "https://buggy.justtestit.org/profile";

        //ScreenshotPath
        public static string ScreenshotPath = CommonMethods.getCodeDirectory() + @"\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = CommonMethods.getCodeDirectory() + @"\TestReports\";



    }
}
