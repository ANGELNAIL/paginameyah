using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly IClienteService _clienteService;
        public DetailsModel(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }
        [BindProperty]
        public Cliente Cliente { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return RedirectToPage("/pagina/Clientes/ClienteVista");
            }
            var _cliente = await _clienteService.GetClienteAsync(id: id);
            this.Cliente = _cliente;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Eliminar")
            {

                var res = await _clienteService.DeleteClienteAsync(id);
                if (res)
                    return RedirectToPage("/pagina/Clientes/ClienteVista");
            }
            return Page();
        }
    }
}
