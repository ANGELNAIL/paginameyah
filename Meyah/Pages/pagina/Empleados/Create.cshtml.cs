using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Empleados
{
    public class CreateModel : PageModel
    {
        private readonly IEmpleadoService _empleadoService;
        public CreateModel(IEmpleadoService empleadoService)
        {

            this._empleadoService = empleadoService;
        }
        [BindProperty]
        public Empleado empleado { get; set; }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            return Page();
        }
        // en esta seccion se llama al metodo post el cual se encargara de enviar la informacion
        // para que se guarde en la bd
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            // la variable res se encarga de almacenar la informacion que entrara en el metodo add
            var res = await _empleadoService.AddEmpleado(this.empleado);
            // si la variable res tiene informacion se guarda y regresa a la pagina principal
            if (res)
                return RedirectToPage("/pagina/Empleados/Index");
            else
                return Page();
        }

    }
}
