using Microsoft.VisualStudio.TestTools.UnitTesting;
using PedirPizza.Models;
using System;
using System.Collections.Generic;
using PedirPizza.Objetos;

namespace PruebasPedirPizza
{
    [TestClass]
    public class PruebasModel
    {
        [TestMethod]
        public void CalcularPrecioCoberturas_Debe_retornar_9240_si_selecciona_todo_Tamanio_grande()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("hongos");
            Coberturas.Add("jamon");
            Coberturas.Add("peperoni");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("Grande", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecioCoberturas(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 9240.0);
        }
        //Hacer mas pruebas solo seleccionando cada valor 

        [TestMethod]
        public void CalcularPrecioTamanio_Debe_retornar_6000_si_Tamanio_pequenia()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();

            Pizza PizzaPrueba = new Pizza("pequenia", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecioTamanio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 6000.0);
        }

        [TestMethod]
        public void CalcularPrecioTamanio_Debe_retornar_6000_si_Tamanio_mediana()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();

            Pizza PizzaPrueba = new Pizza("mediana", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecioTamanio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 9000.0);
        }

        [TestMethod]
        public void CalcularPrecioTamanio_Debe_retornar_6000_si_Tamanio_grande()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();

            Pizza PizzaPrueba = new Pizza("grande", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecioTamanio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 10000.0);
        }

        [TestMethod]
        public void CalcularPrecioTamanio_Debe_retornar_6000_si_Tamanio_gigante()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();

            Pizza PizzaPrueba = new Pizza("gigante", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecioTamanio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 12000.0);
        }

        [TestMethod]
        public void CalcularPrecioTamanio_Debe_retornar_0_si_no_se_selecciona()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();

            Pizza PizzaPrueba = new Pizza("", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecioTamanio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 0.0);
        }

        [TestMethod]
        public void CalcularImpuesto_Debe_retornar_1300_si_precio_10000()
        {
            //Preparacion
            double PrecioPrueba = 10000.0;
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularImpuesto(PrecioPrueba) ;

            //Assert
            Assert.AreEqual(PrecioCobertura, 1300.0);
        }

        [TestMethod]
        public void CalcularImpuesto_Debe_retornar_0_si_precio_0()
        {
            //Preparacion
            double PrecioPrueba = 0.0;
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularImpuesto(PrecioPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 0.0);
        }


        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Pequenia_y_todos_sabores()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("hongos");
            Coberturas.Add("jamon");
            Coberturas.Add("peperoni");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("pequenia", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba );

            //Assert
            Assert.AreEqual(PrecioCobertura, 18821.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Mediana_y_todos_sabores()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("hongos");
            Coberturas.Add("jamon");
            Coberturas.Add("peperoni");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("mediana", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 22211.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Grande_y_todos_sabores()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("hongos");
            Coberturas.Add("jamon");
            Coberturas.Add("peperoni");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("grande", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 23341.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Gigante_y_todos_sabores()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("hongos");
            Coberturas.Add("jamon");
            Coberturas.Add("peperoni");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("gigante", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 25601.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Pequenia_y_solo_Jamon()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");


            Pizza PizzaPrueba = new Pizza("pequenia", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 10301);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Mediana_y_solo_Jamon()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");


            Pizza PizzaPrueba = new Pizza("mediana", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 13691);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Grande_y_solo_Jamon()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");


            Pizza PizzaPrueba = new Pizza("grande", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 14821);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Gigante_y_solo_Jamon()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");


            Pizza PizzaPrueba = new Pizza("gigante", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 17081);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Pequenia_y_solo_Jamon_y_Suprema()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("pequenia", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 14301.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Mediana_y_solo_Jamon_y_Suprema()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("mediana", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 17691.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Grande_y_solo_Jamon_y_Suprema()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("grande", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 18821.2);
        }

        [TestMethod]
        public void CalcularPrecio_Debe_retornar__si_Gigante_y_solo_Jamon_y_Suprema()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");
            Coberturas.Add("suprema");

            Pizza PizzaPrueba = new Pizza("gigante", Coberturas);
            PedirPizzaModel Prueba = new PedirPizzaModel();
            double PrecioCobertura = Prueba.CalcularPrecio(PizzaPrueba);

            //Assert
            Assert.AreEqual(PrecioCobertura, 21081.2);
        }


        [TestMethod]
        public void RevisarSeleccionesCoberturas_Debe_retornar_Vacio_si_seleccionan_Coberturas()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("jamon");
            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba =Prueba.RevisarSeleccionesCoberturas(Coberturas);

            //Assert
            Assert.AreEqual(MensajePrueba,"");
        }

        [TestMethod]
        public void RevisarSeleccionesCoberturas_Debe_retornar_Mensaje_si_no_seleccionan_Coberturas()
        {
            //Preparacion
            List<String> Coberturas = new List<String>();
            Coberturas.Add("");
            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba = Prueba.RevisarSeleccionesCoberturas(Coberturas);

            //Assert
            Assert.AreEqual(MensajePrueba, "Por favor seleccione alguna cobertura para la pizza.");
        }

        
        [TestMethod]
        public void RevisarTamanioPizza_Debe_retornar_Mensaje_si_no_selecciona_Tamanio()
        {
            //Preparacion

            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba = Prueba.RevisarTamanioPizza("");

            //Assert
            Assert.AreEqual(MensajePrueba, "Por favor seleccionar un tamaño para la pizza.");
        }


        [TestMethod]
        public void RevisarTamanioPizza_Debe_retornar_Mensaje_Vacio_si__selecciona_Pequenia()
        {
            //Preparacion

            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba = Prueba.RevisarTamanioPizza("pequenia");

            //Assert
            Assert.AreEqual(MensajePrueba, "");
        }

        [TestMethod]
        public void RevisarTamanioPizza_Debe_retornar_Mensaje_Vacio_si__selecciona_Mediana()
        {
            //Preparacion

            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba = Prueba.RevisarTamanioPizza("mediana");

            //Assert
            Assert.AreEqual(MensajePrueba, "");
        }
        [TestMethod]
        public void RevisarTamanioPizza_Debe_retornar_Mensaje_Vacio_si__selecciona_Grande()
        {
            //Preparacion

            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba = Prueba.RevisarTamanioPizza("grande");

            //Assert
            Assert.AreEqual(MensajePrueba, "");
        }
        [TestMethod]
        public void RevisarTamanioPizza_Debe_retornar_Mensaje_Vacio_si__selecciona_Gigante()
        {
            //Preparacion

            PedirPizzaModel Prueba = new PedirPizzaModel();
            String MensajePrueba = Prueba.RevisarTamanioPizza("gigante");

            //Assert
            Assert.AreEqual(MensajePrueba, "");
        }
    }
}
