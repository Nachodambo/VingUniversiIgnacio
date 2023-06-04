using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages;
using Demoblaze.Auto.Template.WebPages.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class Cart : CommonPage
    {
        public Cart(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();



        //WebElements

       

        private IWebElement btnPlaceOrder
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Place Order']"); }
        }
        private IWebElement nameField
        {
            get { return WebDriver.FindElementById("name"); }
        }

        private IWebElement cardField
        {
            get { return WebDriver.FindElementById("card"); }
        }

        private IWebElement countryField
        {
            get { return WebDriver.FindElementById("country"); }
        }

        private IWebElement cityField
        {
            get { return WebDriver.FindElementById("city"); }
        }

        private IWebElement monthField
        {
            get { return WebDriver.FindElementById("month"); }
        }
        
        private IWebElement yearField
        {
            get { return WebDriver.FindElementById("year"); }
        }

        private IWebElement btnPurchase
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Purchase']"); }
        }
        private IWebElement btnOK
        {
            get { return WebDriver.FindElementByXPath("//button[text()='OK']"); }
        }

        private IWebElement thankYouMessage
        {
            get { return WebDriver.FindElementByXPath("//h2[text()='Thank you for your purchase!']"); }
        }

        private IWebElement selectedItem(String itemName)
        {
            return WebDriver.FindElementByXPath("//td[text()='"+itemName+"']");
        }

        private By welcomeLetter
        {
            get
            {
                return By.XPath("//a[text()='Welcome nachod']");
            }
        }

        private IWebElement detectItem(string itemName)
        {
           return WebDriver.FindElementByXPath("//tr[@class='success']/td[text()='" + itemName + "']/../td/a");
        }                                        
        //metodos

        public Cart clickPlaceOrder()
        {
            btnPlaceOrder.Click();
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout));
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            return this;    
        }
        public Cart fillForm()
        {
            nameField.SendKeys("Angus Young");
            cardField.SendKeys("1234-2223-5246-2342");
            countryField.SendKeys("España");
            cityField.SendKeys("Barcelona");
            monthField.SendKeys("octubre");
            yearField.SendKeys("2029");
            btnPurchase.Click();
            Assert.AreEqual("Thank you for your purchase!", thankYouMessage.Text);
            btnOK.Click();
            return this;
        }

        public Cart verifyItem(string itemName, string selectedItemName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(welcomeLetter));
            Assert.AreEqual(itemName, selectedItem(selectedItemName).Text);
            return this;
        }

        public Cart deleteSelectedItem (string itemName)
        {
           
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(welcomeLetter));
            Thread.Sleep(1000);
            detectItem(itemName).Click();
            return this;
        }
    }
}
