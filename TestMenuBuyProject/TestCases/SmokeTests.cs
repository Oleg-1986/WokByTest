using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TestMenuBuyProject.PageObjects;
using System.Configuration;
using System.Threading;

namespace TestMenuBuyProject.TestCases
{
    class SmokeTests
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
          driver = new ChromeDriver();
        }

        [Test]
        [Obsolete]
        public void Order()
        {
            driver.Url = ConfigurationManager.AppSettings["MainUrl"];
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(500);
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.Click();
        }
        [TearDown]
        public void EndTheTest()
        {
            driver.Close();
        }
    }
}
