using MongoDB.Driver;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCart.Auto.Template.Common;
using NUnit.Framework.Constraints;

namespace OpenCart.Auto.Template.WebPages.Base
{
    public class HomePage : CommonPage
    {
        public HomePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();


        private IWebElement featuredMacBook
        {
            get { return WebDriver.FindElementByXPath("//div[@class='product-thumb transition']//img[@alt='MacBook']"); }

        }

        private IWebElement btnMyAccount
        {
            get { return WebDriver.FindElementByXPath("//i[@class='fa fa-user']"); }

        }//a[text()='Register']

        private IWebElement btnregister
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Register']"); }

        }
        private IWebElement btnLogIn
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Login']"); }

        }
        private IWebElement btnLogout
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Logout']"); }

        }

        private IWebElement btnConfigAvanada
        {
            get { return WebDriver.FindElementById("details-button"); }

        }
   

        private IWebElement btnAcceder
        {
            get { return WebDriver.FindElementById("proceed-link"); }

        }
        
        private IWebElement sponsorName(string name) 
        {
             return WebDriver.FindElementByXPath("//img[@alt='" + name + "']"); 
        }

        private IWebElement searchBar
        {
            get { return WebDriver.FindElementByXPath("// input[@name='search']"); }
        }
        private IWebElement btnSearch
        {
            get { return WebDriver.FindElementByXPath("//i[@class='fa fa-search']"); }
        }
       

        //metodos

        public HomePage entrarAPagina()
        {
            btnConfigAvanada.Click();
            btnAcceder.Click();
            return this;
        }
        public HomePage clickRegister()
        {
            btnMyAccount.Click();
            btnregister.Click();
        
            return this;
        }

        public HomePage clickLogin()
        {
            btnMyAccount.Click();
            btnLogIn.Click();

            return this;
        }


        public HomePage clickFeaturedMacBook()
        {

            featuredMacBook.Click();
            return this;
        }

        public string verifyLogoutbutton()
        {
            btnMyAccount.Click();
            return btnLogout.Text;
        }
        
        public bool checkSponsor(string name) {

            if (sponsorName(name) != null)
            {
                return true;
            }
            else return false;
        }

        public HomePage searchItem(string item)
        {
            searchBar.Click();
            searchBar.SendKeys(item);
            btnSearch.Click();
            return this;
        }

    }
}
