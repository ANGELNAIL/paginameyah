using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Empleados
{
    public class DetailsModel : PageModel
    {
        private readonly IEmpleadoService _empleadoService;
        public DetailsModel(IEmpleadoService empleadoservice)
        {
            this._empleadoService = empleadoservice;
        }
        [BindProperty]
        public Empleado Empleado { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return RedirectToPage("/pagina/Empleados/Index");
            }
            var _empleado = await _empleadoService.GetEmpleadoAsync(id: id);
            this.Empleado = _empleado;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Eliminar")
            {

                var res = await _empleadoService.DeleteEmpleadoAsync(id);
                if (res)
                    return RedirectToPage("/pagina/Empleados/Index");
            }
            return Page();
        }
    }
}
