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
    class LoginTest
    {
        [TestCase("", "KingOfTheRoads86")]
        [TestCase("  ", "KingOfTheRoads86")]
        [TestCase(" oleg@gmail.com ", "KingOfTheRoads86")]
        [TestCase("oleg @gmail.com", "KingOfTheRoads86")]
        [TestCase("oleg@@gmail.com", "KingOfTheRoads86")]
        [TestCase("oleggmail.com", "KingOfTheRoads86")]
        [TestCase("oleg@gmail..com", "KingOfTheRoads86")]
        [TestCase("oleg@gmailcom", "KingOfTheRoads86")]
        [TestCase("oleg@gmail.", "KingOfTheRoads86")]
        [TestCase("oleg@.com", "KingOfTheRoads86")]
        [TestCase("@gmail.com", "KingOfTheRoads86")]
        [TestCase("АПРОллд@gmail.com", "KingOfTheRoads86")]
        [TestCase("ole^%$#g@gma)(il.com", "KingOfTheRoads86")]
        [TestCase("oleg", "KingOfTheRoads86")]
        [TestCase("+375442675498", "KingOfTheRoads86")]
        [TestCase("olegjdskdjksjdjksajdjfdjhrqkjkfkndfnlqjaflklklkdlfdfnndmndlfldljjadlsmcl;@gmail.com", "KingOfTheRoads86")]
        [TestCase("oleg@gmail.com", "")]
        [TestCase("oleg@gmail.com", "  ")]
        [TestCase("oleg@gmail.com", "KingOfBounty2156")]
        [Obsolete]
        public void NewTest(string i, string g)
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Url = ConfigurationManager.AppSettings["AuthUrl"];
            var loginPage = new LoginPage();
            PageFactory.InitElements(_driver, loginPage);
            loginPage.FillFilds(i,g);
            //_driver.Quit();
        }

       
    }
}
