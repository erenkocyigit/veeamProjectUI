using OpenQA.Selenium;
using TechTalk.SpecFlow;
using veeamProject.Drivers;

namespace veeamProject.Features.Hooks
{
    [Binding]
    public sealed class Hooks
    {



        [AfterScenario]
        public void AfterScenario()
        {
            Driver.closeDriver();
        }
    }
}