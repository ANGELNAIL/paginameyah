using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Pedidos
{
    public class IndexModel : PageModel
    {
        private readonly IPedidoService _PedidoService;
        private readonly IProductoService _ProductoService;
        private readonly IClienteService _clienteService;

        public IndexModel(IPedidoService pedidoservice, IProductoService productoService, IClienteService clienteService)
        {
            this._PedidoService = pedidoservice;
            this._ProductoService = productoService;
            this._clienteService = clienteService;
        }
        public IEnumerable<Pedido> PedidoList;
        public IEnumerable<Cliente> ClienteList;
        public IEnumerable<Producto> ProductoList;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _clienteList = await _clienteService.GetClientesAsync();
            this.ClienteList = _clienteList;

            var _pedidoList = await _PedidoService.GetPedidosAsync();
            this.PedidoList = _pedidoList;

            var _productoList = await _ProductoService.GetProductosAsync();
            this.ProductoList = _productoList;
            return Page();
        }
    }
}
