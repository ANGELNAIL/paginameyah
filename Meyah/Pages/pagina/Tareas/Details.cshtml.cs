using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Tareas
{
    public class DetailsModel : PageModel
    {
        private readonly ITareaService _TareaService;
        public DetailsModel(ITareaService tareaService)
        {
            this._TareaService = tareaService;
        }
        [BindProperty]
        public Tarea Tarea { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return RedirectToPage("/pagina/Productos/GetProduct");
            }
            var _tarea = await _TareaService.GetTareaAsync(id: id);
            this.Tarea = _tarea;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Eliminar")
            {

                var res = await _TareaService.DeleteTareaAsync(id);
                if (res)
                    return RedirectToPage("/pagina/Tareas/Index");
            }
            return Page();
        }
    }
}
