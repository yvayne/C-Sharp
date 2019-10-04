using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Project_CSharp;
using System;
using TechTalk.SpecFlow;

[Binding]
public class ReportSteps
{
    static ExtentTest featureName;
    static ExtentTest scenario;
    static ExtentTest step;
    static ExtentReports extendReport;
    static ScenarioContext _scenarioContext;
    static FeatureContext _featureContext;

    private const String GIVEN = "Given";
    private const String WHEN = "When";
    private const String AND = "And";
    private const String THEN = "Then";

    public ReportSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
    {
        _scenarioContext = scenarioContext;
        _featureContext = featureContext;

    }

    [BeforeTestRun]
    public static void SetUpReport()
    {
        ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(FileManager.GetProyectPath() + "Report\\dashboard.html");
        htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
        extendReport = new ExtentReports();
        extendReport.AttachReporter(htmlReport);
    }

    [AfterTestRun]
    public static void SaveReport()
    {
        extendReport.Flush();
    }

    [BeforeFeature]
    public static void BeforeFeature()
    {
        featureName = extendReport.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
    }
   
    [BeforeScenario]
    public void BeforeTest()
    {
        string FeatureTitle = _featureContext.FeatureInfo.Title;
        Console.WriteLine("FeatureTitle :" + FeatureTitle);
        string ScenarioTitle = _scenarioContext.ScenarioInfo.Title;
        Console.WriteLine("ScenarioTitle :" + ScenarioTitle);
    }

    [AfterStep]
    public static void InsertReportingSteps()
    {
        string stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
        if (ScenarioContext.Current.TestError == null)
        {
            if (stepType.Equals(GIVEN))
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            else if (stepType.Equals(WHEN))
                scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
            else if (stepType.Equals(AND))
                scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            else if (stepType.Equals(THEN))
                scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
        }
    }
}