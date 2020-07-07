using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedirPizza.Objetos;

namespace PedirPizza.Models
{
    public class PedirPizzaModel
    {

        public double CalcularPrecio(Pizza PizzaOrdenada)
        {
            //Datos quemados para pruebas


            double PrecioFinal = 0.0;
            double PrecioCoberturas =CalcularPrecioCoberturas(PizzaOrdenada);

            return PrecioFinal;
        }

        public double CalcularPrecioCoberturas(Pizza pizza)
        {
            double PrecioCoberturas = 0.0;
            foreach (String cobertura in pizza.Coberturas)
            {
                switch (cobertura)
                {
                    case "hongos":
                        PrecioCoberturas += 1500.0;
                        break;
                    case "jamon":
                        PrecioCoberturas += 1700.0;
                        break;
                    case "peperoni":
                        PrecioCoberturas += 2500.0;
                        break;
                    case "suprema":
                        PrecioCoberturas += 3540.0;
                        break;

                }
            }

            return PrecioCoberturas;
        }

    }
}
