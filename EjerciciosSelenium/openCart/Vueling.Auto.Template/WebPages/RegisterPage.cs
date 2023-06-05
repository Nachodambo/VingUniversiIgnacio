using OpenCart.Auto.Template.SetUp;
using OpenCart.Auto.Template.WebPages.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCart.Auto.Template.Common;

namespace OpenCart.Auto.Template.WebPages
{
    public class RegisterPage : CommonPage
    {
        public RegisterPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement fierstNamenield
        {
            get { return WebDriver.FindElementById("input-firstname"); }

        }
        private IWebElement lastNameField
        {
            get { return WebDriver.FindElementById("input-lastname"); }

        }
        private IWebElement emailField
        {
            get { return WebDriver.FindElementById("input-email"); }

        }
        private IWebElement telefoneField
        {
            get { return WebDriver.FindElementById("input-telephone"); }

        }
        private IWebElement passwordField
        {
            get { return WebDriver.FindElementById("input-password"); }

        }
        private IWebElement confirmPasswordField
        {
            get { return WebDriver.FindElementById("input-confirm"); }

        }

        private IWebElement btnAgreePrivatePolicy
        {
            get { return WebDriver.FindElementByXPath("//input[@type='checkbox']");}
        }

        private IWebElement btnContinue
        {
            get { return WebDriver.FindElementByXPath("//input[@type='submit']"); }
        }
        private IWebElement btnContinue2
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Continue']"); }
        }
        private IWebElement btnYourStore
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Your Store']"); }
        }

        //metodos

        public RegisterPage fillFormAndRegister()
        {
            fierstNamenield.SendKeys(Helpers.GetRandomString(8));
            lastNameField.SendKeys("Deniro");
            emailField.SendKeys(Helpers.GetRandomString(8)+".d@gmail.com");
            telefoneField.SendKeys("1234567890");
            passwordField.SendKeys("Robert");
            confirmPasswordField.SendKeys("Robert");
            btnAgreePrivatePolicy.Click();
            btnContinue.Click();
            btnContinue2.Click();
            btnYourStore.Click();
            return this;
        }

      

       
    }


}
