using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTests
{
    internal class NewlyCreatedRepositoryPage
    {
        private IWebDriver driver;

        public NewlyCreatedRepositoryPage(IWebDriver driver, string mainWindowHandle = null)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        public NewlyCreatedRepositoryPage NavigateToNewlyCreatedRepository(string url)
        {
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl($"https://github.com/program-sigma/{url}");
            return this;
        }
    }
}
