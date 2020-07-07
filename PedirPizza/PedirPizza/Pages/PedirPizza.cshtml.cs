using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PedirPizza.Controllers;
using PedirPizza.Objetos;

namespace PedirPizza.Pages
{
    public class PedirPizzaModel : PageModel
    {

        PedirPizzaController PedirController;

        public String MensajeTamanio { get; set; }

        public String MensajeCoberturas { get; set; }

        public void OnPost()
        {
            String Tamanio = Request.Form["tamanio"].ToString();
            String Coberturas = Request.Form["point#2"].ToString();

            List<String> CoberturasL = new List<String>();

            CoberturasL = Coberturas.Split(',').ToList();

            PedirController = new PedirPizzaController();

            MensajeTamanio = PedirController.ComunicarRevisionTamanio(Tamanio);
            MensajeCoberturas = PedirController.ComunicarRevisionCoberturas(CoberturasL);


            if (MensajeTamanio == "" || MensajeCoberturas == "")
            {
                Pizza PizzaOrdenada = new Pizza(Tamanio, CoberturasL);

                PedirController.ComunicarPizza(PizzaOrdenada);
            }


        }
    }
}