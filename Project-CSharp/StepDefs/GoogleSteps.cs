using Project_CSharp.Core.WebDriver;
using System;
using TechTalk.SpecFlow;

namespace Project_CSharp.StepDefs
{
    [Binding]
    public class GoogleSearchSteps
    {
        [Given(@"I go to ""(.*)"" url")]
        public void GivenIGoToUrl(string url)
        {
            DriverManager.GetInstance().GetWebDriver().Navigate().GoToUrl(url);
        }
    }
}
