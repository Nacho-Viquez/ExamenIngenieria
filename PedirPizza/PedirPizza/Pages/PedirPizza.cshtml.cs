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

        public void OnPost()
        {
            String Tamanio = Request.Form["point#1"].ToString();
            String Coberturas = Request.Form["point#2"].ToString();

            List<String> CoberturasL = new List<String>();

            CoberturasL = Coberturas.Split(',').ToList();

            PedirController = new PedirPizzaController();

            Pizza PizzaOrdenada = new Pizza(Tamanio, CoberturasL);

            PedirController.ComunicarPizza(PizzaOrdenada);

        }
    }
}