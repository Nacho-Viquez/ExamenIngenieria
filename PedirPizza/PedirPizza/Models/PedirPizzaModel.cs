using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedirPizza.Objetos;

namespace PedirPizza.Models
{
    public class PedirPizzaModel
    {


        public String RevisarTamanioPizza(String Tamanio)
        {
            String Mensaje = "";
            if (Tamanio == "")
            {
                Mensaje = "Por favor seleccionar un tamaño para la pizza.";
            }

            return Mensaje;
        }

        public String RevisarSeleccionesCoberturas(List<String> Coberturas)
        {
            String Mensaje = "";
            if (Coberturas[0] == "")
            {
                Mensaje = "Por favor seleccione alguna cobertura para la pizza.";
            }
            return Mensaje;
        }


        public double CalcularPrecio(Pizza PizzaOrdenada)
        {
            //Datos quemados para pruebas

            double Envio = 1600;
            double PrecioFinal = 0.0;
            double PrecioTamanio = CalcularPrecioTamanio(PizzaOrdenada);
            double PrecioCoberturas =CalcularPrecioCoberturas(PizzaOrdenada);
            PrecioFinal = PrecioTamanio + PrecioCoberturas;
            PrecioFinal += CalcularImpuesto(PrecioFinal);
            PrecioFinal += Envio;

            return PrecioFinal;
        }


        public double CalcularImpuesto(double Precio)
        {
            double Impuesto;

            return Impuesto = Precio *0.13;
        }


        public double CalcularPrecioTamanio(Pizza PizzaOrden)
        {
            double Precio = 0.0;
            switch (PizzaOrden.Tamanio)
            {
                case "pequenia":
                    Precio = 6000;
                    break;
                case "mediana":
                    Precio = 9000;
                    break;
                case "grande":
                    Precio = 10000;
                    break;
                case "gigante":
                    Precio = 12000;
                    break;
            }

            return Precio;
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
