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
    public class YopmailInboxPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"mail\"]/div/div/table/tbody/tr[2]/td/h2")]
        private IWebElement totalCostHeader;

        [FindsBy(How = How.Id, Using = "refresh")]
        private IWebElement buttonRefresh;

        public YopmailInboxPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string GetTotalCost()
        {
            Thread.Sleep(3000);
            buttonRefresh.Click();
            totalCostHeader = WaitForElementLocatedBy(_driver, By.XPath("//*[@id=\"mail\"]/div/div/table/tbody/tr[2]/td/h2"));
            return totalCostHeader.Text;
        }

        private static IWebElement WaitForElementLocatedBy(IWebDriver driver, By by)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                    .Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by)).Single();
        }
    }
}
