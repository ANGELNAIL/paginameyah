using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Pedidos
{
    public class DetailsModel : PageModel
    {
        private readonly IClienteService _ClienteService;
        private readonly IProductoService _ProductoService;
        private readonly IPedidoService _pedidoService;
        public DetailsModel(IPedidoService pedidoService, IProductoService productoService, IClienteService clienteService)
        {
            this._ClienteService = clienteService;
            this._pedidoService = pedidoService;
            this._ProductoService = productoService;
        }
        [BindProperty]
        public Pedido pedido { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var _productoList = await _ProductoService.GetProductosAsync();
            this.productoList = _productoList;
            var _clienteList = await _ClienteService.GetClientesAsync();
            this.clienteList = _clienteList;

            if (id == 0)
            {
                return RedirectToPage("/pagina/Pedidos/Index");
            }
            var _pedido = await _pedidoService.GetPedidoAsync(id: id);
            this.pedido = _pedido;
            return Page();
        }
        public IEnumerable<Producto> productoList;
        public IEnumerable<Cliente> clienteList;

        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Eliminar")
            {

                var res = await _pedidoService.DeletePedidoAsync(id);
                if (res)
                    return RedirectToPage("/pagina/Pedidos/Index");
            }
            return Page();
        }
    }
}