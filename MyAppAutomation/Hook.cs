using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyAppAutomation
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        public static IWebDriver Driver { get; private set; }

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Initialize ChromeDriver before each scenario
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Quit driver after each scenario
            Driver.Quit();
        }
    }
}
