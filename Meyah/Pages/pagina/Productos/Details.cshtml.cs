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
    public class DetailsModel : PageModel
    {
        // llamamos la interfaz del producto la cual contiene la lista de metodos que seran implementados en el api
        private readonly IProductoService _ProductoService;
        // aqui definimos las variables que utilizaremos 
        public DetailsModel(IProductoService productoService)
        {
            this._ProductoService = productoService;
        }
        // utilizamos la propiedad BindProperty para indicar que se recibe informacion
        [BindProperty]
        // instanciamos la clase propducto para poder presetar la informacion de cada propiedad  
        public Producto producto { get; set; }
        // se implementa el metodo get de manera asincronica, el cual recibe la id que corresponde al producto,
        // esto es para buscar unicamente el producto que coincida con la id del recibida
        public async Task<IActionResult> OnGetAsync(int id)
        {
            // si la id es igual a 0 se redirige a la pagina principal de la gestion de productos 
            if (id == 0)
            {
                return RedirectToPage("/pagina/Productos/ProductoVista");
            }
            // la variable producto se encarga de almacenar la informacion recibida del metodo get
            var _producto = await _ProductoService.GetProductoAsync(id: id);
            this.producto = _producto;
            return Page();
        }
        // el metodo eliminar funciona de maner similar al metodo get 
        // esta evaluda la id recibida y elimina la coincidencia de la base de datos 
        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Eliminar")
            {

                var res = await _ProductoService.DeleteProductodAsync(id);
                if (res)
                    return RedirectToPage("/pagina/Productos/ProductoVista");
            }
            return Page();
        }
    }
}