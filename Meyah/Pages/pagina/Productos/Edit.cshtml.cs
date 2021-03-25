using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Productos
{
    public class EditModel : PageModel
    {
        private readonly IProductoService _ProductoService;
        public EditModel(IProductoService ProductoService)
        {
            this._ProductoService = ProductoService;
        }
        [BindProperty]
        public Producto Producto { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {

            if (id == 0)
            {
                return RedirectToPage("/pagina/Productos/ProductoVista");
            }
            var _pedido = await _ProductoService.GetProductoAsync(id: id);
            this.Producto = _pedido;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Guardar")
            {
                var res = await _ProductoService.UpdateProductoAsync(this.Producto);
                if (res)
                    return RedirectToPage("/pagina/Productos/ProductoVista");
            }
            return Page();
        }
    }
}
