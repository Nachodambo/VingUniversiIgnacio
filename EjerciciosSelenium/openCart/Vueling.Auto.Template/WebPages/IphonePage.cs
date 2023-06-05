using OpenCart.Auto.Template.Common;
using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class IphonePage : CommonPage
    {
        public IphonePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//span[text()='Add to Cart']"); }
        }
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cart-total"); }
        }
        private IWebElement btnViewCart
        {
            get { return WebDriver.FindElementByXPath("//strong[text()=' View Cart']/..//i[@class='fa fa-shopping-cart']"); }
        }
        private IWebElement btnCheckout
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Checkout']"); }
        }
        private By btnYourStore
        {
            get { return By.XPath("//a[text()='Your Store']"); }
        }
        private IWebElement btnYourStor
        {
            get { return WebDriver.FindElementByXPath("//h1/a"); }
        }
        //button-cart
      
        public IphonePage AddAndGoToCart()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10)).Until(CustomExpectedConditions.ElementIsVisible(btnYourStore));
            btnAddToCart.Click();
            btnCart.Click();
            btnViewCart.Click();
            return this;    
        }

        public IphonePage goToStore()
        {
            btnYourStor.Click();
            return this;
        }
        public void clickCheckout()
        {
            btnCheckout.Click();
        }
    }
}
