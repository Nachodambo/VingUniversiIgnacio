using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Demoblaze.Auto.Template.SetUp;
using Demoblaze.Auto.Template.WebPages.Base;
using Demoblaze.Auto.Template.Common;
using OpenQA.Selenium.Support.UI;
using Demoblaze.Auto.Template.WebPages;
using MongoDB.Driver;
using System.Threading;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;

namespace Demoblaze.Auto.Template.WebPages
{
    public class FlyHome : CommonPage
    {
        public FlyHome(ISetUpWebDriver setUpWebDriver) : base(setUpWebDriver)
        {
        }

        protected override IWebElement ApartadosBusqueda => throw new NotImplementedException();


        //elementos 

        private IWebElement origenBtn
        {
            get { return WebDriver.FindElementByXPath("//label[text()='Origen']"); }
        }
        

        private IWebElement origenField
        {
            ///*[@id=\"searcher\"]/div[1]/div[1]/div/div[2]/div/input
            //(//input[@class='input-value'])[1]
            get { return WebDriver.FindElementByXPath("//input[@placeholder='¿Desde dónde?']"); }
        }

        private IWebElement btnBarcelona
        {
            get { return WebDriver.FindElementByXPath("//div[text()='Barcelona']"); }
        }

        

        private IWebElement btnAcceptCookies
        {
            get { return WebDriver.FindElementById("ensCloseBanner"); }
        }

        private By cookiesMessage
        {
            get { return By.Id("ensBannerDescription"); }
        }

      
        private IWebElement destinoField
        {
            get { return WebDriver.FindElementByXPath("(//input[@class='input-value'])[2]"); }
        }

        private IWebElement btnBuenosAires
        {
            get { return WebDriver.FindElementByXPath("(//div[@class='city' and text()='Buenos Aires'])[2]"); }
        }

        private IWebElement btnCiudadOrigen(string nombre)
        {
             return WebDriver.FindElementByXPath("//div[text()='"+nombre+"']"); 
        }

        private IWebElement btnCiudadDestino(string nombre)
        {
            return WebDriver.FindElementByXPath("(//div[@class='city' and text()='"+nombre+"'])[2]"); 
        }

        private IWebElement btnDay9June
        {
            get { return WebDriver.FindElementByXPath("//div[@data-time='1686261600000']"); }
        }

        private IWebElement btnDay10June
        {
            get { return WebDriver.FindElementByXPath("//div[@data-time='1686348000000']"); }
        }

        private IWebElement btnPlus
        {
            get { return WebDriver.FindElementByXPath("(//span[@class='icon-plus pax-icon'][1])"); }
        }

        private IWebElement btnListo
        {
            get { return WebDriver.FindElementByXPath("//button[@class='btn btn-pax large secondary']"); }
        }

        private IWebElement btnBuscarVuelo
        { 
            get { return WebDriver.FindElementByXPath("//span[@class='context-title' and text()='Buscar vuelos' ]"); }
        }

        private IWebElement btnNextmonth
        {
            get { return WebDriver.FindElementByClassName("datepicker__next-action"); }
        }

        private IWebElement mesEnCalendario
        {
          get { return WebDriver.FindElementByXPath("//div[@class='datepicker__month-title']/span[@class='month']"); }
        }
        //span[@class='month' and text()='septiembre']


        private IWebElement primerDiaDisponinble
        {
            get { return WebDriver.FindElementByXPath("//section[@class='datepicker__month'][1]//div[@class='datepicker__day is-available '][1]"); }
        }
     

        private IWebElement diaRetorno(int fecha)

        {
            //TERMINAR ESTO
            return WebDriver.FindElementByXPath("//div[@class='datepicker__months']//section[@class='datepicker__month'][1]//div[@class='datepicker__days']//div[text()='"+fecha+"']");
            
                                                 //section[@class='datepicker__month'][1]//div[@class='datepicker__day is-available is-in-range']//div[text()='"+fecha+"']
        }

        //div[@data-field="child"]//div[@class='js-plus']

        private IWebElement btnPlusCHL
        {
            get { return WebDriver.FindElementByXPath("( //div[@data-field='child']//div[@class='js-plus'])"); }
        }



        //metodos

        public FlyHome acceptCookies()
        {
            new WebDriverWait(WebDriver, TimeSpan.FromSeconds(WaitTimeout)).Until(CustomExpectedConditions.ElementIsVisible(cookiesMessage));
            btnAcceptCookies.Click();
            return this;
        }
        public FlyHome seleccionarOrigen()
        {
            origenBtn.Click();
            origenField.SendKeys("Barcelona");
            btnBarcelona.Click();
            return this;
        }                                 

        public FlyHome seleccionarDestino()
        {
            //Thread.Sleep(2000);
            //btnDestino.Click();
            destinoField.SendKeys("Buenos Aires");
            btnBuenosAires.Click();
            return this;
        }
        public FlyHome selecccionarDias()
        {
            btnDay9June.Click();
            btnDay10June.Click();
            return this;
        }

        public FlyHome addOneADT()
        {
            btnPlus.Click();
            btnListo.Click();
            return this;
        }
        public FlyHome buscarVuelo()
        {
            btnBuscarVuelo.Click();
            return this;
        }
       

      

        public FlyHome seleccionarOrigenYDestino(string cityOrigen, string cityDestino)
        {   
           
            origenBtn.Click();
            origenField.SendKeys(cityOrigen);
            btnCiudadOrigen(cityOrigen).Click();
            destinoField.SendKeys(cityDestino);
            btnCiudadDestino(cityDestino).Click();
           

            return this;
        }

      
        public FlyHome entontrarMes(string mes)
        {
            while (true)
            {
                btnNextmonth.Click();          
                if (mesEnCalendario.Text == mes.ToUpper())
                {
                    break;
                }
            }
            return this;
            
        }

        public FlyHome seleccionarPrimerDiaDisponibleYvuelta()
        {
            string fechaIda = primerDiaDisponinble.Text;

            int numeroVuelta = int.Parse(fechaIda) + 11;
            string stringVuelta = numeroVuelta.ToString();
            Console.WriteLine(stringVuelta);
            primerDiaDisponinble.Click();
            diaRetorno(numeroVuelta).Click();
            return this;
        }

        public FlyHome add3ADT1CHL()
        {
            for (int i = 0; i < 2; i++){
                btnPlus.Click();
            }
            btnPlusCHL.Click();


            btnListo.Click();
            return this;
        }









    }
}
