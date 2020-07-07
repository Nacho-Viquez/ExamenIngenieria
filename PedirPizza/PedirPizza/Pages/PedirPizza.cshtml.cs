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

        public string Precio = "";
        [TempData]
        public string PrecioPagar { get; set; }

        public String Localizacion { get; set; }

        public List<String> Selecciones { get; set; }

        public String Tamanio { get; set; }

        [TempData]
        public string ValorPagar { get; set; }

        public void OnPost()
        {

            String TamanioTemp = Request.Form["tamanio"].ToString();
            String CoberturasTemp = Request.Form["point#2"].ToString();
            
            List<String> CoberturasL = new List<String>();

            CoberturasL = CoberturasTemp.Split(',').ToList();
            PedirController = new PedirPizzaController();


            MensajeTamanio = PedirController.ComunicarRevisionTamanio(TamanioTemp);
            MensajeCoberturas = PedirController.ComunicarRevisionCoberturas(CoberturasL);


            if ((MensajeTamanio == "") && (MensajeCoberturas == ""))
            {
                //Retorno del precio
                Pizza PizzaOrdenada = new Pizza(TamanioTemp, CoberturasL);

                double PrecioPizza= PedirController.ComunicarPizza(PizzaOrdenada);
                PrecioPagar =  PrecioPizza.ToString();
                

                Response.Redirect("ConfirmarPedido ");
                
            }


            

        }
    }
}