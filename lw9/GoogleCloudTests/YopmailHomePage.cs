using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCloudTests
{
    public class YopmailHomePage
    {
        private const int WAIT_TIMEOUT_SECONDS = 20;
        private const string HOMEPAGE_URL = "https://yopmail.com/email-generator";
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='nw']/button[1]")]
        private IWebElement buttonGenerateNewEmail;

        [FindsBy(How = How.XPath, Using = "//div[@class='nw']/button[2]")]
        private IWebElement buttonCheckInbox;

        [FindsBy(How = How.XPath, Using = "//div[@id='egen']//div[@id='geny']")]
        private IWebElement divGeneratedEmail;

        public YopmailHomePage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public YopmailHomePage OpenPage()
        {
            driver.Navigate().GoToUrl(HOMEPAGE_URL);
            new WebDriverWait(driver, TimeSpan.FromSeconds(WAIT_TIMEOUT_SECONDS));
            return this;
        }

        public string GetNewEmailAddress()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)");

            buttonGenerateNewEmail.Click();
            divGeneratedEmail = WaitForElementLocatedBy(driver, By.XPath("//div[@id='egen']//div[@id='geny']"));
            return divGeneratedEmail.Text.Trim();
        }

        public YopmailHomePage GoToInbox()
        {
            buttonCheckInbox.Click();
            return this;
        }

        private static IWebElement WaitForElementLocatedBy(IWebDriver driver, By by)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                    .Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by)).Single();
        }
    }
}
