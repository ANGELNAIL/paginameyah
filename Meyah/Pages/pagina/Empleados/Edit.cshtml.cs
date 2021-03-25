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
    public class EditModel : PageModel
    {
        private readonly IEmpleadoService _empleadoService;
        public EditModel(IEmpleadoService empleadoService)
        {
            this._empleadoService = empleadoService;
        }
        [BindProperty]
        public Empleado empleado { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {

            if (id == 0)
            {
                return RedirectToPage("/pagina/Productos/ProductoVista");
            }
            var _empleado = await _empleadoService.GetEmpleadoAsync(id: id);
            this.empleado = _empleado;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();
            if (button == "Guardar")
            {
                var res = await _empleadoService.UpdateEmpleadoAsync(this.empleado);
                if (res)
                    return RedirectToPage("/pagina/Empleados/Index");
            }
            return Page();
        }
    }
}