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
    public class CanonPage : CommonPage
    {
        public CanonPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
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
       
        private By btnYourStore
        {
            get { return By.XPath("//a[text()='Your Store']"); }
        }
        private IWebElement btnViewCart
        {
            get { return WebDriver.FindElementByXPath("//p[@class='text-right']//i[@class='fa fa-shopping-cart']"); }
        }
        private IWebElement btnsendToCart
        {
            get { return WebDriver.FindElementById("button-cart"); }
        }

        //metodos

        public CanonPage AddAndGoToCart()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10)).Until(CustomExpectedConditions.ElementIsVisible(btnYourStore));
            btnAddToCart.Click();
            btnsendToCart.Click();
            btnCart.Click();
            btnViewCart.Click();


            return this;
        }
    }
}
