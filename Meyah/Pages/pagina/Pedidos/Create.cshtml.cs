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
    public class CreateModel : PageModel
    {        
        private readonly IClienteService _ClienteService;
        private readonly IProductoService _ProductoService;
        private readonly IPedidoService _pedidoService;
        public CreateModel(IPedidoService pedidoService, IProductoService productoService,IClienteService clienteService )
        {
            this._ClienteService = clienteService;
            this._pedidoService = pedidoService;
            this._ProductoService = productoService;
        }
        [BindProperty]
        public Pedido pedido { get; set; }
        public Producto producto { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _productoList = await _ProductoService.GetProductosAsync();
            this.productoList = _productoList;
            var _clienteList = await _ClienteService.GetClientesAsync();
            this.clienteList = _clienteList;
            return Page();
        }
        
        public IEnumerable<Producto> productoList;
        public IEnumerable<Cliente> clienteList;
        public async Task<IActionResult> OnPostAsync()
        {
            var _productoList = await _ProductoService.GetProductosAsync();
            this.productoList = _productoList;
            int num = pedido.productoId;
            foreach (var item in productoList)
            {

                if (num == item.productoId)
                {
                    pedido.precio = item.precio * pedido.cantidad;
                }
            }
            var res = await _pedidoService.AddPedido(this.pedido);

            if (res)
                return RedirectToPage("/pagina/Pedidos/Index");
                return Page();
        }

    }
}
