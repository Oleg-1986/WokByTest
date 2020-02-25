using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestMenuBuyProject.PageObjects
{
    class HomePage
    {
        //Elements for Header StickyNavLinks
       [FindsBy(How=How.XPath, Using = "//a[@data-index='1']")]
       private IWebElement  Wok{ get; set; }
       [FindsBy(How = How.XPath, Using = "//a[@data-index='2']")]
       private IWebElement Noodle  { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='3']")]
        private IWebElement StireFry { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='4']")]
        private IWebElement Soups { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='5']")]
        private IWebElement Poke { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='6']")]
        private IWebElement Plove { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='7']")]
        private IWebElement LightFood { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='8']")]
        private IWebElement PartyWok { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='9']")]
        private IWebElement Deserts { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-index='10']")]
        private IWebElement Drinks { get; set; }

        public void ClickLinks()
        {
            Wok.Click();
            Noodle.Click();
            StireFry.Click();
            Soups.Click();
            Poke.Click();
            Plove.Click();
            LightFood.Click();
            PartyWok.Click();
            Deserts.Click();
            Drinks.Click();
        }

        //Find elements for Header Relative Nav Links
        [FindsBy(How=How.XPath, Using = "//li[@class='header-relative-nav__item']")]
        private IWebElement Payment { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@data-modal-id='modal-location-selection']")]
        private IWebElement Delivery { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[@class='header-working-info__day-text']")]
        private IWebElement Info_Day { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@href='header-relative-nav__link header-relative-nav__link--accaunt']")]
        private IWebElement Authorization { get; set; }

        public void ClickPayment()
        {
            Payment.Click();
        }
        public void ClickDelivery()
        {
            Delivery.Click();
        }
        public void ClickInfoDay()
        {
            Info_Day.Click();
        }
        public void ClickAuthorization()
        {
            Authorization.Click();
        }      
        //Elements for SmokeTests
        [FindsBy(How=How.XPath, Using= "//div[@id='bx_1803894673_24']//button[@class='product-card-add-btn']")]
        private IWebElement bt { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='bx_1803894673_24']//button[@data-role='input-quantity-max']")]
        private IWebElement bt2 { get; set; }
        [FindsBy(How=How.XPath, Using = "//div[@id='bx_4069289515_35']//button[@class='product-card-add-btn']")]
        private IWebElement bt3 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='bx_3770772645_45']//button[@class='product-card-add-btn']")]
        private IWebElement bt4 { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@id='bx_3770772645_45']//button[@data-role='input-quantity-min']")]
        private IWebElement bt5 { get; set; }

        public void Click()
        {
            Wok.Click();
            bt.Click();
            for (int i = 0; i < 20; i++)
            {
                bt2.Click();
            }
            Soups.Click();
            bt3.Click();
            Deserts.Click();
            bt4.Click();
            bt5.Click();
           
           
        }
    }
}
