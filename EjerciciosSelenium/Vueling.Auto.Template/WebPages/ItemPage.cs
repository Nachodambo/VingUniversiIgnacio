using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Auto.Template.WebPages
{
    public class ItemPage : CommonPage
    {
        public ItemPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();


        //elements


        //Add to cart

        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Add to cart']"); }
        }

        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }

        //metodos
        public ItemPage clickAddToCart()
        {
            btnAddToCart.Click();   
            return this;
        }

        public ItemPage clickCart()
        {
            btnCart.Click();
            return this;
        }
    }
}
