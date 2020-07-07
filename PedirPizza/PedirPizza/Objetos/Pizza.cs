using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedirPizza.Objetos
{

   
    public class Pizza
    {

        public List<String> Coberturas { get; set; }

        public String Tamanio { get; set; }

        public Pizza(String Tamanio, List<String> Coberturas)
        {
            this.Coberturas = Coberturas;

            this.Tamanio = Tamanio;

        }

    }
}
