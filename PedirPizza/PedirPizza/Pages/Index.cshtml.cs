using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PedirPizza.Pages
{
    public class IndexModel : PageModel
    {

        [TempData]
        public String MensajeConfirmacion { get; set; }

        public String Mensaje = "";

        public void OnGet()
        {
            if (MensajeConfirmacion != null)
            {
                Mensaje = MensajeConfirmacion;
            }
        }


        public void OnPost()
        {
            Response.Redirect("PedirPizza");
        }
    }
}
