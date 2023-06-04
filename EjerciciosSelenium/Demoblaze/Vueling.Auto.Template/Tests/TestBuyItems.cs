using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demoblaze.Auto.Template.WebPages;
using Vueling.Auto.Template.WebPages;
using System.Threading;

namespace Demoblaze.Auto.Template.Tests
{
    [TestFixture]
    class DevicesTest : TestSetCleanBase
    {
       

        [TestCase]
        public void laptopPurchase()
        {
            homePage = new HomePage(setUpWebDriver);
            logIn = new LogInPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            itemPage = new ItemPage(setUpWebDriver);
            
            //acciones
            homePage.clickLogIn();
            logIn.toLogIn();
            string itemName = "Sony vaio i5";
            homePage.selectItem(itemName);
            itemPage.clickAddToCart();
            itemPage.clickCart();
            cart.clickPlaceOrder();
            cart.fillForm();
        }
        [TestCase]
        public void phonePurchase() {
            homePage = new HomePage(setUpWebDriver);
            logIn = new LogInPage(setUpWebDriver);
            phonePage = new PhonePage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            //acciones
            homePage.clickLogIn();
            logIn.toLogIn();
            String sectionName = "Phones";
            homePage.clickSection(sectionName);
            String phoneName = "Samsung galaxy s6";
            homePage.selectPhone(phoneName);
            phonePage.clickAddToCart();
            phonePage.clickCart();
            cart.clickPlaceOrder();
            cart.fillForm();
        }

        [TestCase]

        public void monitorPurchase()
        {
            homePage = new HomePage(setUpWebDriver);
            logIn = new LogInPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            monitorPage = new MonitorPage(setUpWebDriver);
            
            
            //funciones
            homePage.clickLogIn();
            logIn.toLogIn();
            String sectionName = "Monitors";
            homePage.clickSection(sectionName);
            String monitorName = "ASUS Full HD";
            homePage.selectItem(monitorName);
            monitorPage.clickAddToCart();
            monitorPage.clickCart();
            cart.clickPlaceOrder();
            cart.fillForm();

        }

        [TestCase]

        public void addTwoItems()
        {
            homePage = new HomePage(setUpWebDriver);
            logIn = new LogInPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            phonePage = new PhonePage(setUpWebDriver);
            laptopPage = new LaptopPage(setUpWebDriver);
            //funciones
            homePage.clickLogIn();
            logIn.toLogIn();
            String sectionName = "Phones";
            homePage.clickSection(sectionName);
            String phoneName = "Nokia lumia 1520";
            homePage.selectItem(phoneName);
            phonePage.clickAddToCart();
            phonePage.clickHome();
            sectionName = "Laptops";
            homePage.clickSection(sectionName);
            String laptopName = "MacBook air";
            homePage.selectItem(laptopName);
            laptopPage.clickAddToCart() ;
            laptopPage.clickCart() ;
            cart.verifyItem(laptopName, laptopName);
            cart.verifyItem(phoneName, phoneName);


        }

        [TestCase]  

        public void deleteChosenItem() {

            homePage = new HomePage(setUpWebDriver);
            logIn = new LogInPage(setUpWebDriver);
            cart = new Cart(setUpWebDriver);
            phonePage = new PhonePage(setUpWebDriver);
            laptopPage = new LaptopPage(setUpWebDriver);
            //funciones
            homePage.clickLogIn();
            logIn.toLogIn();
            String sectionName = "Phones";
            homePage.clickSection(sectionName);
            string phoneName = "Nokia lumia 1520";
            homePage.selectItem(phoneName);
            phonePage.clickAddToCart();
            phonePage.clickHome();
            sectionName = "Laptops";
            homePage.clickSection(sectionName);
            string laptopName = "MacBook air";
            homePage.selectItem(laptopName);
            laptopPage.clickAddToCart();
            laptopPage.clickCart();
            Thread.Sleep(1000);
            cart.deleteSelectedItem(phoneName);



        }
       

    }
}
