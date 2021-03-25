using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Clientes
{
    public class CreateModel : PageModel
    {
        private readonly IClienteService _clienteService;
        public CreateModel(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }
        [BindProperty]
        public Cliente cliente { get; set; }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            // la variable res se encarga de almacenar la informacion que entrara en el metodo add
            var res = await _clienteService.Addcliente(this.cliente);
            // si la variable res tiene informacion se guarda y regresa a la pagina principal
            if (res)
                return RedirectToPage("/pagina/Clientes/ClienteVista");
            else
                return Page();
        }
    }
}
