using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
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
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentTest step;
        public Hooks(IObjectContainer container)
        {
            objectContainer = container;
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            CommonMethods.ExtentReports();
        }
        [BeforeFeature]
        public static void BeforeFeture(FeatureContext featureContext)
        {
            featureName = CommonMethods.extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            driver = Driver.GetDriver();
            objectContainer.RegisterInstanceAs(driver);
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }
        [AfterStep]
        public void InsertReportingSteps(ScenarioContext scenarioContext, IWebDriver driver)
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            switch (stepType)
            {
                case "Given":
                    step = scenario.CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text);
                    break;
                case "When":
                    step = scenario.CreateNode<When>(scenarioContext.StepContext.StepInfo.Text);
                    break;
                case "And":
                    step = scenario.CreateNode<And>(scenarioContext.StepContext.StepInfo.Text);
                    break;
                case "Then":
                    step = scenario.CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text);
                    break;
                default:
                    break;
            }

            if (scenarioContext.TestError != null)
            {
                var screenshotFilePath = CommonMethods.TryToTakeScreenshot(driver);
                if (screenshotFilePath != null)
                {
                    step.Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotFilePath).Build());
                }
                else
                {
                    step.Fail(scenarioContext.TestError.Message);
                }
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close(driver);
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            CommonMethods.extent.Flush();
        }
    }
}
