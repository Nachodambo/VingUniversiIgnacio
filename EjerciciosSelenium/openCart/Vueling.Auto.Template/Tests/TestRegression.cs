using NUnit.Framework;
using OpenCart.Auto.Template.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCart.Auto.Template.WebPages.Base;
using OpenCart.Auto.Template.WebPages;
using OpenCart.Auto.Template.SetUp;
using NUnit.Framework.Internal.Execution;
using OpenCart.Auto.Template.Common;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace OpenCart.Auto.Template.Tests
{
    [TestFixture]
    public class TestRegression : TestSetCleanBase
    {
        [TestCase] 
        public void registerFunctionality()
        {
            homePage = new HomePage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);
             homePage.entrarAPagina();
            homePage.clickRegister();
            registerPage.fillFormAndRegister();
        }
        [TestCase]
        public void loginFunctionality() {
            homePage = new HomePage(setUpWebDriver);
            loginPage = new LogInPage(setUpWebDriver);
            homePage.entrarAPagina();
            homePage.clickLogin();
            loginPage.fillFormAndLogin();
            Assert.AreEqual("Logout", homePage.verifyLogoutbutton());
        }



        [TestCase]
        public void buyFeaturedMacBook()
        {

            homePage = new HomePage(setUpWebDriver);
            macBookPage = new MacBookPage(setUpWebDriver);
            registerPage= new RegisterPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            checkoutPage = new CheckoutPage(setUpWebDriver);

            homePage.entrarAPagina();
            homePage.clickRegister();
            registerPage.fillFormAndRegister();
            Assert.AreEqual("Logout", homePage.verifyLogoutbutton());          
            homePage.clickFeaturedMacBook();
            macBookPage.clickbtnAddToCart();
            macBookPage.clickViewCart();
            Assert.AreEqual("MacBook", cart.getLaptopName());
            cart.clickCheckout();
            checkoutPage.completeStep2();
            checkoutPage.completeStep3();           
            checkoutPage.confirmOrder();
            Assert.AreEqual("Your order has been placed!", checkoutPage.orderWasPlaced());
            checkoutPage.clickContinue();
        }

        [TestCase]
        public void searchBarFunctionality()
        {
            homePage = new HomePage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            iphonePage = new IphonePage(setUpWebDriver);
            checkoutPage = new CheckoutPage(setUpWebDriver);

            homePage.entrarAPagina();
            homePage.clickRegister();
            registerPage.fillFormAndRegister();
            Assert.AreEqual("Logout", homePage.verifyLogoutbutton());
            homePage.searchItem("iphone");
            iphonePage.AddAndGoToCart();
            iphonePage.clickCheckout();
            checkoutPage.completeStep2();
            checkoutPage.clickContunueSt3();
            checkoutPage.clickContinueStep4();
            checkoutPage.clickContinueStep5();
            checkoutPage.confirmOrder();
            Assert.AreEqual("Your order has been placed!", checkoutPage.orderWasPlaced());
            checkoutPage.clickContinue();
        }

        [TestCase]
        public void removeItemsfunctionality()
        {
            homePage = new HomePage(setUpWebDriver);
            registerPage = new RegisterPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            iphonePage = new IphonePage(setUpWebDriver);
            macBookPage = new MacBookPage(setUpWebDriver);
            checkoutPage = new CheckoutPage(setUpWebDriver);
             canonPage = new CanonPage(setUpWebDriver);

            homePage.entrarAPagina();
            homePage.clickRegister();
            registerPage.fillFormAndRegister();
            Assert.AreEqual("Logout", homePage.verifyLogoutbutton());
            homePage.searchItem("iphone");
            iphonePage.AddAndGoToCart();
            iphonePage.goToStore();
            homePage.searchItem("canon");
            canonPage.AddAndGoToCart();


        }




        [TestCase]
        public void findSponsor()
        { 
            homePage = new HomePage(setUpWebDriver);
            homePage.entrarAPagina();
            Assert.AreEqual(true, homePage.checkSponsor("Nintendo"));

        }

    }
}
