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
    public class ClienteVistaModel : PageModel
    {
        private readonly IClienteService _ClienteService;
        public ClienteVistaModel(IClienteService clienteService)
        {
            this._ClienteService = clienteService;
        }
        public IEnumerable<Cliente> ClienteList;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _clienteList = await _ClienteService.GetClientesAsync();
            this.ClienteList = _clienteList;
            return Page();
        }
    }
}
