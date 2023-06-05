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
    public class LaptopPage : CommonPage
    {
        public LaptopPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        //Elementos
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

        public LaptopPage clickAddToCart()
        {
            btnAddToCart.Click();
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();
            return this;
        }

        public LaptopPage clickCart()
        {
            btnCart.Click();
            return this;
        }
    }
}
