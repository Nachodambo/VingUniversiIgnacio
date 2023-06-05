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
    public class CheckoutPage : CommonPage
    {
        public CheckoutPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement firstNamenField
        {
            get { return WebDriver.FindElementById("input-payment-firstname"); }

        }
        private IWebElement lastNameField
        {
            get { return WebDriver.FindElementById("input-payment-lastname"); }

        }
        private IWebElement address1Field
        {
            get { return WebDriver.FindElementById("input-payment-address-1"); }

        }
        private IWebElement cityField
        {
            get { return WebDriver.FindElementById("input-payment-city"); }

        }
        private IWebElement postCodeField
        {
            get { return WebDriver.FindElementById("input-payment-postcode"); }

        }
        private IWebElement countryField
        {
            get { return WebDriver.FindElementById("input-payment-country"); }

        }
        private IWebElement regionStateField
        {
            get { return WebDriver.FindElementById("input-payment-zone"); }

        }
        
        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementById("button-payment-address"); }

        }
        private IWebElement btnContinueStep3
        {
            get { return WebDriver.FindElementById("button-payment-method"); }

        }
        private IWebElement optionUruguay
        {
            get { return WebDriver.FindElementByXPath("//select[@name='country_id']//option[@value='225']"); }

        }
        private IWebElement optionMontevideo
        {
            get { return WebDriver.FindElementByXPath("//option[text()='Montevideo']"); }

        }

        private IWebElement commentsField
        {
            get { return WebDriver.FindElementByXPath("//textarea[@name='comment']"); }
        }

        private IWebElement btnTermsAndConds
        {
            get { return WebDriver.FindElementByXPath("//input[@name='agree']"); }

        }

        private IWebElement btnUseSameAddress
        {
            get { return WebDriver.FindElementByXPath("//input[@type='radio' and @name='payment_address']"); }
        }
       


        private IWebElement orderPlacedLeter
        {
            get { return WebDriver.FindElementByXPath("//h1[text()='Your order has been placed!']"); }

        }

        private IWebElement btnConfirmOrder
        {
            get { return WebDriver.FindElementById("button-confirm"); }
        }
        private IWebElement btnLastContinue
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue']"); }
        }

        private IWebElement btnStep3Continue
        {
            get { return WebDriver.FindElementById("button-shipping-address"); }
        }
        private IWebElement btnStep4Continue
        {
            get { return WebDriver.FindElementById("button-shipping-method"); }
        }
        private IWebElement btnStep5Continue
        {
            get { return WebDriver.FindElementById("button-payment-method"); }
        }
        private IWebElement campoEditableStep5
        {
            get { return WebDriver.FindElementByXPath("(//textarea[@name='comment'])[2]"); }
        }
        //metodos button-payment-method

        public CheckoutPage completeStep2()
        {
           
                firstNamenField.SendKeys("Robert");
                lastNameField.SendKeys("Deniro");
                address1Field.SendKeys("427 Hereford street");
                cityField.SendKeys("Christchurch");
                postCodeField.SendKeys("1254");
                countryField.Click();
                optionUruguay.Click();
                regionStateField.Click();
                optionMontevideo.Click();
                btnContinue.Click();
            
            return this;
        }
      
        public CheckoutPage completeStep3()
        {
            commentsField.SendKeys("Hola, este campo es editable");
           
            btnTermsAndConds.Click();
            btnContinueStep3.Click();
            

            return this;
        }
        public string orderWasPlaced()
        {
            return orderPlacedLeter.Text;
        }
        public CheckoutPage confirmOrder()
        {
            btnConfirmOrder.Click();         
            return this;
        }

        public CheckoutPage clickContinue()
        {
            btnLastContinue.Click();
            return this;
        }


        public CheckoutPage clickContunueSt3()
        {
            btnStep3Continue.Click();
            return this;
        }
        public CheckoutPage clickContinueStep4() {
            commentsField.SendKeys("Hola, este campo es editable");
            btnStep4Continue.Click();
            return this;    
        }
        public CheckoutPage clickContinueStep5()
        {
            
            btnTermsAndConds.Click();
            btnStep5Continue.Click();
            return this;
        }

    }
}
