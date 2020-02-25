using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TestMenuBuyProject.PageObjects
{
    class LoginPage
    {
        [FindsBy(How=How.XPath, Using = "//input[@data-validation='email']")][CacheLookup]
        private IWebElement Email { get; set; }
        [FindsBy(How=How.XPath, Using = "//input[@type='password']")][CacheLookup]
        private IWebElement Password { get; set; }
        [FindsBy(How=How.XPath, Using = "//button[@type='submit']")][CacheLookup]
        private IWebElement Submit { get; set; }
        //[TestCase("olegbishkevitch@gmail.com", "KingOfTheRoads86")]

        public void FillFilds(string i, string g)
        {
            Email.SendKeys(i);
            Password.SendKeys(g);
           // Submit.Click();
           
        }

        

        
    }
}
