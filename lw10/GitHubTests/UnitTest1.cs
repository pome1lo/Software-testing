using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace GitHubTests
{
    public class Tests
    {
        private IWebDriver _driver;
        private int random_number;
        private string repositoryName;

        [SetUp]
        public void BrowserSetup()
        {
            _driver = new EdgeDriver();
            _driver.Manage().Window.Maximize();

        }

        [SetUp]
        public void Setup()
        {
            random_number = new Random().Next(1, 100000);
            repositoryName = $"TEST_REPOSITORY_{random_number}";
        }

        [Test]
        public void CreateNewRepository()
        {
            new LoginPage(_driver)
              .Login();

            new NewRepositoryPage(_driver)
                .NavigateToNewPage()
                .CreateNewRepository(repositoryName);

            new NewlyCreatedRepositoryPage(_driver)
                .NavigateToNewlyCreatedRepository(repositoryName);

            var expectedResult = $"https://github.com/program-sigma/{repositoryName}";
            var actualResult = _driver.Url;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}