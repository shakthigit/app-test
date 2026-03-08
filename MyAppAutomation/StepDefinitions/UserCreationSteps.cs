using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MyAppAutomation.Pages;
using NUnit.Framework;

namespace MyAppAutomation.StepDefinitions
{
    [Binding]
    public class UserCreationSteps
    {
        private IWebDriver _driver;
        private UserCreationPage _userPage;

        [Given(@"I navigate to the user creation page")]
        public void GivenINavigateToTheUserCreationPage()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://localhost:5000/createUser");
            _userPage = new UserCreationPage(_driver);
        }

        [When(@"I enter name ""(.*)""")]
        public void WhenIEnterName(string name) => _userPage.EnterName(name);

        [When(@"I enter age ""(.*)""")]
        public void WhenIEnterAge(string age) => _userPage.EnterAge(age);

        [When(@"I enter mailID ""(.*)""")]
        public void WhenIEnterMailID(string mailID) => _userPage.EnterMailID(mailID);

        [When(@"I enter occupation ""(.*)""")]
        public void WhenIEnterOccupation(string occupation) => _userPage.EnterOccupation(occupation);

        [When(@"I select gender ""(.*)""")]
        public void WhenISelectGender(string gender) => _userPage.SelectGender(gender);

        [When(@"I click the create button")]
        public void WhenIClickTheCreateButton() => _userPage.ClickCreate();

        [Then(@"the user should be created successfully")]
        public void ThenTheUserShouldBeCreatedSuccessfully()
        {
            Assert.IsTrue(_userPage.IsSuccessDisplayed());
            _driver.Quit();
        }
    }
}
