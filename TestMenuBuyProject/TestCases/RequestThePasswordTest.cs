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

namespace TestMenuBuyProject.TestCases
{
    class RequestThePasswordTest
    {
        [TestCase("oleg@gmail.com")]
        [TestCase("")]
        [TestCase("  ")]
        [TestCase("victor@gmail.com")]
        [Obsolete]
        public void ForgotPasswordTest(string i)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["ForgotUrl"];
            var forgotThePasswordPage = new ForgotThePasswordPage();
            PageFactory.InitElements(driver, forgotThePasswordPage);
            forgotThePasswordPage.U_Email_Test(i);
        }
    }
}
