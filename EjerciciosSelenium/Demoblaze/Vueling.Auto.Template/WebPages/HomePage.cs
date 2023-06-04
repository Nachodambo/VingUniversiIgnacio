using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using Demoblaze.Auto.Template.Common;
using OpenQA.Selenium.Support.UI;
using Vueling.Auto.Template.WebPages;

namespace Demoblaze.Auto.Template.WebPages
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }
        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();


        //Elementos de HomePage
        private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Home ']"); }
        }

        private IWebElement btnSignUp
        {
            get { return WebDriver.FindElementByXPath("//a[text()= 'Sign up']"); }
        }

        private IWebElement btnLogIn
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Log in']"); }
        }

       

        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }

        private IWebElement btnAboutUs
        {
            get {return WebDriver.FindElementByXPath("//a[text()='About us']");}
        }

        private IWebElement btnContact
        {
            get {return WebDriver.FindElementByXPath("//a[text()='Contact']"); }
        }

        private IWebElement btnAddOrder
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Place Order']"); }
        }

       
       
        private IWebElement findItem(string itemName)
        {
            return WebDriver.FindElementByXPath("//a[text()='" + itemName + "']");
        }

        private By itemsBody
        {
            get { return By.Id("tbodyid"); } 
        }

        private By welcomeLetter
        {
            get
            {
                return By.XPath("//a[text()='Welcome nachod']");
            }
        }
        private IWebElement btnItemSection(String sectionName)
        {
            return WebDriver.FindElementByXPath("//a[text()='"+ sectionName +"']"); 
        }


        //  Metodos
        public HomePage clickHome()
        {
            btnCart.Click();
            return this;
        }
        public HomePage clickAddOrder()
        {
            btnAddOrder.Click();
            return this;
        }

        //phone
        public HomePage clickSection(String sectionName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(welcomeLetter));
            btnItemSection(sectionName).Click();
            return this;
        }
        private IWebElement phoneItem(String phoneName)
        {
            return WebDriver.FindElementByXPath("//a[text()='" + phoneName + "']");
        }
        //

       

        public HomePage clickLogIn() {
            btnLogIn.Click();
            return this;
        }

        public HomePage clickCart() {

            btnCart.Click();
            return this;
        }

        public HomePage selectPhone(String phoneName)
        {

            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(welcomeLetter));
            phoneItem(phoneName).Click();
            return this;
        }

        public HomePage selectItem(string itemName)
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(welcomeLetter));
            findItem(itemName).Click();
            return this;
        }

    }


}
