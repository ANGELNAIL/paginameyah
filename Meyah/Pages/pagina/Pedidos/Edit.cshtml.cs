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
    public class EditModel : PageModel
    {
        private readonly IClienteService _ClienteService;
        private readonly IProductoService _ProductoService;
        private readonly IPedidoService _pedidoService;
        public EditModel (IPedidoService pedidoService, IProductoService productoService, IClienteService clienteService)
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
            var _productoList = await _ProductoService.GetProductosAsync();
            this.productoList = _productoList;
            int num = pedido.productoId;
            foreach (var item in productoList)
            {
                if (num == item.productoId)
                {
                    pedido.precio = item.precio * pedido.cantidad;
                    pedido.pedidoId = id;
                    pedido.fechaentrega = pedido.fechaentrega;
                } 
            }
            if (button == "Guardar")
            {

                var res = await _pedidoService.UpdatePedidoAsync(this.pedido);
                if (res)
                    return RedirectToPage("/pagina/Pedidos/Index");
            }
            return Page();
        }
    }
}
