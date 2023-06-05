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
    public class LogInPage : CommonPage
    {
        public LogInPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        private IWebElement emailField
        {
            get { return WebDriver.FindElementById("input-email"); }

        }
        private IWebElement passwordField
        {
            get { return WebDriver.FindElementById("input-password"); }

        }
        private IWebElement btnLogin
        {
            get { return WebDriver.FindElementByXPath("//input[@value='Login']"); }
        }
        private IWebElement btnYourStore
        {
            get { return WebDriver.FindElementByXPath("//a[text()='Your Store']"); }
        }

        public LogInPage fillFormAndLogin()
        {
            emailField.SendKeys("Ardnold.d@gmail.com");
            passwordField.SendKeys("Robert");
            btnLogin.Click();
            btnYourStore.Click();
            return this;
        }
    }
}
