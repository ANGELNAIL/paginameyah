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
    public class EditModel : PageModel
    {
        private readonly ITareaService _tareaService;
        private readonly IEmpleadoService _empleadoService;
        private readonly IPedidoService _pedidoService;
        public EditModel(IPedidoService pedidoService, IEmpleadoService empleadoService, ITareaService tareaService)
        {
            this._empleadoService = empleadoService;
            this._pedidoService = pedidoService;
            this._tareaService = tareaService;
        }
        [BindProperty]
        public Tarea tarea { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var _PedidoList = await _pedidoService.GetPedidosAsync();
            this.PedidoList = _PedidoList;
            var _EmpleadoList = await _empleadoService.GetEmpleadosAsync();
            this.EmpleadoList = _EmpleadoList;

            if (id == 0)
            {
                return RedirectToPage("/pagina/Tareas/Index");
            }
            var _tarea = await _tareaService.GetTareaAsync(id: id);
            this.tarea = _tarea;
            return Page();
        }
        public IEnumerable<Empleado> EmpleadoList;
        public IEnumerable<Pedido> PedidoList;

        public async Task<IActionResult> OnPostAsync(int id, string button)
        {
            if (!ModelState.IsValid)
                return Page();

            if (button == "Actualizar")
            {
                var res = await _tareaService.UpdateTareaAsync(this.tarea, id);
                if (res)
                    return RedirectToPage("/pagina/Tareas/Index");
            }
            return Page();
        }
    }
}