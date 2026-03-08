using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MyAppAutomation.Pages;
using NUnit.Framework;

namespace MyAppAutomation.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://localhost:5000/login");
            _loginPage = new LoginPage(_driver);
        }

        [When(@"I enter username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            Assert.IsFalse(_loginPage.IsErrorDisplayed());
            _driver.Quit();
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_loginPage.IsErrorDisplayed());
            _driver.Quit();
        }
    }
}
