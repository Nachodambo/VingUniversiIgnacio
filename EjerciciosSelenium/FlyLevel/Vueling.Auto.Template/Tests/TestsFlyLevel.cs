using Demoblaze.Auto.Template.Tests;
using Demoblaze.Auto.Template.WebPages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demoblaze.Auto.Template.WebPages;

namespace Demoblaze.Auto.Template.Tests
{
    class FlyLevelTests
    {
        [TestFixture]
        class TestFlyLevel : TestSetCleanBase
        {

            [TestCase]
            public void buy2ADTticket()
            {
                flyHome = new FlyHome(setUpWebDriver);

                flyHome.acceptCookies();
                flyHome.seleccionarOrigen();
                flyHome.seleccionarDestino();
                flyHome.selecccionarDias();
                flyHome.addOneADT();
                flyHome.buscarVuelo();
            }

            [TestCase]

            public void BCNaSCLticketRT()
            {
                flyHome = new FlyHome(setUpWebDriver);
                flyHome.acceptCookies();
                string origen = "Barcelona";
                string destino = "Santiago de Chile";
                flyHome.seleccionarOrigenYDestino(origen, destino);
                flyHome.entontrarMes("septiembre");
                flyHome.seleccionarPrimerDiaDisponible();
                
                //flyHome.clickearVuelta();

            }

        }
    }
}