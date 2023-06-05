using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages.Base
{
    public class MacBookPage : CommonPage
    {
        public MacBookPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();


        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementById("button-cart"); }
        }

        ////div[@id='cart']
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cart-total"); }
        }
        //strong[text()=' View Cart']
        private IWebElement btnViewCart
        {
            get { return WebDriver.FindElementByXPath("//strong[text()=' View Cart']"); }
        }

        public MacBookPage clickbtnAddToCart()
        {
            btnAddToCart.Click();
            return this;
        }
        public MacBookPage clickViewCart()
        {
            btnCart.Click();    
            btnViewCart.Click();
            return this;
        }

    }
}
