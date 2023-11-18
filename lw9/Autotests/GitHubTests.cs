using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace Autotests;

[TestFixture]   
public class Tests
{
    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new EdgeDriver();
    }

    [Test]
    public void CreateRepositry()
    { 
        driver.Navigate().GoToUrl("https://github.com/login");

        IWebElement usernameField = driver.FindElement(By.Name("login"));
        usernameField.SendKeys("myemail");

        IWebElement passwordField = driver.FindElement(By.Name("password"));
        passwordField.SendKeys("mypassword");

        IWebElement signInButton = driver.FindElement(By.Name("commit"));
        signInButton.Click();

        Assert.IsTrue(true);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}