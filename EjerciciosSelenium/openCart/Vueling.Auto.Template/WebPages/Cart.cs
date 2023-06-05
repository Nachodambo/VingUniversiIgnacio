using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCart.Auto.Template.WebPages
{
    public class Cart : CommonPage
    {
        public Cart(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //a[text()='Checkout']

        protected IWebElement btnCheckOut
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Checkout']"); }
        }

        protected IWebElement macBookItem
        {     
           get { return WebDriver.FindElementByXPath("//div[@class='table-responsive']//a[text()='MacBook']"); }
        }
        //metodo

        public string getLaptopName()
        {
            return macBookItem.Text;
        }
        public Cart clickCheckout()
        {
            btnCheckOut.Click();
            return this;
        }


    }
}
