using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Productos
{
    public class ProductoVistaModel : PageModel
    {
        private readonly IProductoService _ProductoService;
        public ProductoVistaModel(IProductoService productoService)
        {
            this._ProductoService = productoService;
        }
        public IEnumerable<Producto> productoList;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _productoList = await _ProductoService.GetProductosAsync();
            this.productoList = _productoList;
            return Page();
        }
    }
}
