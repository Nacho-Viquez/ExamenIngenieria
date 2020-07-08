using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PedirPizza.Pages
{
    public class ConfirmarPedidoModel : PageModel
    {

        public String Informacion { get; set; }

        [TempData]
        public String MensajeConfirmacion { get; set; }

        [TempData]
        public string PrecioPagar { get; set; }

        public void OnGet()
        {
            Informacion = "El monto a pagar es: " + PrecioPagar ;
        }

        public void OnPost()
        {
            String Entrega = Request.Form["localizacionEnvio"].ToString();

            if (Entrega != "")
            {
                MensajeConfirmacion = "Se ha completado la orden, en unos momentos recibira su orden en la dirección: " + Entrega;
            }
            else
            {
                MensajeConfirmacion = "";
            }

            Response.Redirect("Index");
        }
    }
}