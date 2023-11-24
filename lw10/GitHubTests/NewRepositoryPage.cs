using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTests
{
    internal class NewRepositoryPage
    { 
        private IWebDriver driver;

        public NewRepositoryPage(IWebDriver driver, string mainWindowHandle = null)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public NewRepositoryPage NavigateToNewPage()
        {
            driver.Navigate().GoToUrl("https://github.com/new");
            return this;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\":r2:\"]")]
        private IWebElement inputRepositoryName;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[6]/main/react-app/div/form/div[5]/button")]
        private IWebElement buttonCreate;

        public NewRepositoryPage CreateNewRepository(string repositoryName)
        {
            inputRepositoryName.SendKeys(repositoryName);
            Thread.Sleep(1000);
            buttonCreate.Submit();
            return this;
        }
    }
}