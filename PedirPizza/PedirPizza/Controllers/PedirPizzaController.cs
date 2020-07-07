using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedirPizza.Models;
using PedirPizza.Objetos;

namespace PedirPizza.Controllers
{
    public class PedirPizzaController
    {
        PedirPizzaModel PedirModel = new PedirPizzaModel();

        public String ComunicarRevisionTamanio(String Tamanio)
        {
            String Mensaje ;
            return Mensaje = Mensaje = PedirModel.RevisarTamanioPizza(Tamanio);

        }



        public double ComunicarPizza(Pizza PizzaOrdenada)
        {
            double Precio = 0.0;
            Precio = PedirModel.CalcularPrecio(PizzaOrdenada);
            return Precio;
        }


    }
}
