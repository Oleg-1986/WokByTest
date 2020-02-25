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


namespace TestMenuBuyProject.TestCases.LinksTests
{
    class HeaderRelativeNavLinkTest
    {
       
        
            

        [Test]   
        [Obsolete]
        public void LinksTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["MainUrl"];
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.ClickPayment();
        }

        [Test]
        [Obsolete]
        public void LinksTest3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["MainUrl"];
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.ClickDelivery();
        }

        [Test]
        [Obsolete]
        public void LinksTest4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["MainUrl"];
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.ClickInfoDay();
        }

        [Test]
        [Obsolete]
        public void LinksTest5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["MainUrl"];
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.ClickAuthorization();
        }
    }
}
