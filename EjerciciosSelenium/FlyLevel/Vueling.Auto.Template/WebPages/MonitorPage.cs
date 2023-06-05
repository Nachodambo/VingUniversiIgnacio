using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze.Auto.Template.WebPages
{
    public class MonitorPage : CommonPage
    {
        public MonitorPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement btnAddToCart
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Add to cart']"); }
        }

        private IWebElement btnCart
        {
            get { return WebDriver.FindElementById("cartur"); }
        }

        //metodos

        public MonitorPage clickAddToCart()
        {
            btnAddToCart.Click();
            
            return this;
        }
        public MonitorPage clickCart()
        {
            btnCart.Click();
            return this;
        }
    }

    


}
