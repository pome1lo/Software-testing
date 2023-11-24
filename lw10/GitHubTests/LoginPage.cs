using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.ObjectModel;


namespace GitHubTests
{
    internal class LoginPage
    {
        private IWebDriver driver; 

        public LoginPage(IWebDriver driver, string mainWindowHandle = null)
        {
            this.driver = driver; 
            PageFactory.InitElements(driver, this);
        }

        public LoginPage Login()
        {
            driver.Navigate().GoToUrl("https://github.com/login");

            IWebElement usernameField = driver.FindElement(By.Name("login"));
            usernameField.SendKeys("my email U_U");

            IWebElement passwordField = driver.FindElement(By.Name("password"));
            passwordField.SendKeys("my password (●'◡'●)");

            IWebElement signInButton = driver.FindElement(By.Name("commit"));
            signInButton.Click();

            return this;
        }
    }
}
