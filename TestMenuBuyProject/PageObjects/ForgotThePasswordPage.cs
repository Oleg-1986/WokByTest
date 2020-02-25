using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMenuBuyProject.PageObjects
{
    class ForgotThePasswordPage
    {
        [FindsBy(How=How.XPath, Using = "//input[@name='USER_EMAIL']")]
        private IWebElement U_Email { get; set; }

        public void U_Email_Test(string i)
        {
            U_Email.SendKeys(i);
        }
    }
}
