using Demoblaze.Auto.Template.Common;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Auto.Template.WebPages
{
    public class PhonePage : CommonPage
    {
        public PhonePage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //Elementos
        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Add to cart']"); }
        }

        private IWebElement btnHome
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Home ']"); }
        }
        private By welcomeLetter
        {
            get
            {
                return By.XPath("//a[text()='Welcome nachod']");
            }
        }
        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }

        //metodos

        public PhonePage clickAddToCart()
        {
            btnAddToCart.Click();
           
            return this;
        }
        public PhonePage clickCart()
        {
            btnCart.Click();
            return this;
        }

        public PhonePage clickHome()
        {
            btnHome.Click();
            return this;
        }

    }
}
