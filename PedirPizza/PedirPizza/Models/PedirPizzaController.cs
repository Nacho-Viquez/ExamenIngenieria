using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedirPizza.Objetos;

namespace PedirPizza.Models
{
    public class PedirPizzaController
    {

        public double CalcularPrecio()
        {
            //Datos quemados para pruebas
            String Tamanio = "mediana";
            List<String> Coberturas = new List<String>();
            Coberturas.Add("Hongos");
            Coberturas.Add("Peperoni");
            Pizza Prueba = new Pizza(Tamanio,Coberturas);

            double PrecioFinal = 0.0;
             double PrecioCoberturas =CalcularPrecioCoberturas(Prueba);

            return PrecioFinal;
        }

        public double CalcularPrecioCoberturas(Pizza pizza)
        {
            double PrecioCoberturas = 0.0;
            foreach (String cobertura in pizza.Coberturas)
            {
                switch (cobertura)
                {
                    case "Hongos":
                        PrecioCoberturas += 1500.0;
                        break;
                    case "Jamon":
                        PrecioCoberturas += 1700.0;
                        break;
                    case "Peperoni":
                        PrecioCoberturas += 2500.0;
                        break;
                    case "Suprema":
                        PrecioCoberturas += 3540.0;
                        break;

                }
            }

            return PrecioCoberturas;
        }

    }
}
