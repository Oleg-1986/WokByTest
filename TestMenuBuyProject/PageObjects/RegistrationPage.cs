using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMenuBuyProject.PageObjects
{
    class RegistrationPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='EMAIL']")]
        private IWebElement R_Email { get; set; }
        [FindsBy(How=How.XPath, Using = "//input[@name='PERSONAL_PHONE']")]
        private IWebElement R_Phone { get; set; }
        [FindsBy(How=How.XPath, Using = "//input[@name='USER_PASSWORD']")]
        private IWebElement R_Password { get; set; }
        [FindsBy(How=How.XPath, Using = "//input[@name='USER_CONFIRM_PASSWORD']")]
        private IWebElement R_Confirm_Password { get; set; }
        [FindsBy(How=How.XPath, Using = "//button[@class='button button--red button--right delivery__submit-btn']")]
        private IWebElement R_Submit { get; set; }

        public void Fill_Elements(string i, string x, string a)
        {
            R_Email.SendKeys(i);
            R_Phone.SendKeys(x);
            R_Password.SendKeys(a);
            R_Confirm_Password.SendKeys(a);
            //R_Submit.Click();
        }

        public void Fill_Elements2(string i, string x, string a, string b)
        {
            R_Email.SendKeys(i);
            R_Phone.SendKeys(x);
            R_Password.SendKeys(a);
            R_Confirm_Password.SendKeys(b);
        }
    }
}
