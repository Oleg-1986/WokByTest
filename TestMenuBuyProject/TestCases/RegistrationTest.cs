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
    class RegistrationTest
    {
        [TestCase("oleg@gmail.com", "+37529234567","supperSTRONG1985")]
        [TestCase("","+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+37529234567", "")]
        [TestCase("   ", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "   ", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+37529234567", "  ")]
        [TestCase("oleggmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmailcom", "+37529234567", "supperSTRONG1985")]
        [TestCase(" oleg@gmail.com ", "+37529234567", "supperSTRONG1985")]
        [TestCase("ol eg@gmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg$%@@gmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@*{}[]gmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gma;:*/il.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@@gmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleglkcalfkalfnalflalkfnklajdflkajflkjalkfakjfklajfkladklfndajfhgljsdlfslfnlakfjklam@gmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "29234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "375292345", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "37529234567234", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "gJtebdoKL", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "67Hjk9432nj", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+37529234567$%@&^", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "-37529234567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "8(29)2345678", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+(3)7)52)923)4567", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+375--29--2--345--67", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", " +37529234567 ", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+375 29 23 45 67", "supperSTRONG1985")]
        [TestCase("oleg@gmail.com", "+37529234567", "s8pPe")]
        [TestCase("oleg@gmail.com", "+37529234567", "suppeR")]
        [TestCase("oleg@gmail.com", "+37529234567", "@#$%^&}{}??:")]
        [TestCase("oleg@gmail.com", "+37529234567", " supperSTRONG1985 ")]
        [TestCase("oleg@gmail.com", "+37529234567", "supper STRONG 1985")]
        [TestCase("oleg@gmail.com", "+37529234567", "supperSTRsdhhshskskdjsk854758457458hfdjhfjdhfkdjkfdjkjdkfjkjdkfdj8954859")]

        [Obsolete]
        public void RegTest( string i, string x, string a)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["RegUrl"];
            var registrationPage = new RegistrationPage();
            PageFactory.InitElements(driver, registrationPage);
            registrationPage.Fill_Elements( i, x, a);            
        }


        [TestCase("oleg@gmail.com", "+37529234567", "supperSTRONG1985", "supperWeak1234")]
        [TestCase("oleg@gmail.com", "+37529234567", "supperSTRONG1985", "")]
        [TestCase("oleg@gmail.com", "+37529234567", "supperSTRONG1985", "  ")]
        [Obsolete]
        public void RegTest2(string i, string x, string a, string b)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["RegUrl"];
            var registrationPage = new RegistrationPage();
            PageFactory.InitElements(driver, registrationPage);
            registrationPage.Fill_Elements2(i, x, a, b);

        }
    }
}
