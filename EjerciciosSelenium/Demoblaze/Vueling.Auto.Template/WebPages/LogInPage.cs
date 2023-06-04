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
    public class LogInPage : CommonPage
    {
        public LogInPage(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();

        //Elements

        private IWebElement btnLogInForm
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Log in']"); }
        }

        private IWebElement btnCloseLogInForm
        {
            get { return WebDriver.FindElementByXPath("//button[text()='Close']"); }
        }

        private By _btnCloseLogInForm
        {
            get { return By.XPath("//*[@id=\"logInModal\"]/div/div/div[3]/button[1]"); }
        }
        private IWebElement logInUsername
        {
            get { return WebDriver.FindElementById("loginusername"); }
        }

        private IWebElement logInPassword
        {
            get { return WebDriver.FindElementById("loginpassword"); }
        }



        public LogInPage toLogIn()
        {
            logInUsername.SendKeys("nachod");
            logInPassword.SendKeys("nachod");
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(_btnCloseLogInForm));
            btnLogInForm.Click();
            return this;

        }
    }
}
