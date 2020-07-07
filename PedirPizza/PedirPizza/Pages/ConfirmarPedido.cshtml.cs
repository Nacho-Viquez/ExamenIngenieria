using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PedirPizza.Pages
{
    public class ConfirmarPedidoModel : PageModel
    {



        [TempData]
        public String MensajeConfirmacion { get; set; }

        [TempData]
        public string PrecioPagar { get; set; }

      


        public void OnPost()
        {
            String Entrega = Request.Form["localizacionEnvio"].ToString();

            MensajeConfirmacion = "Se ha completado la orden, en unos momentos recibira su orden en la dirección: " +
                Entrega;
            Response.Redirect("Index");
        }
    }
}