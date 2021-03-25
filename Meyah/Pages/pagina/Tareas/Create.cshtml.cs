using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Tareas
{
    public class CreateModel : PageModel
    {
        private readonly ITareaService _tareaService;
        private readonly IPedidoService _pedidoService;
        private readonly IEmpleadoService _empleadoService;
        public CreateModel(ITareaService tareaService, IEmpleadoService empleadoService, IPedidoService pedidoService)
        {
            this._tareaService = tareaService;
            this._empleadoService = empleadoService;
            this._pedidoService = pedidoService;
        }
        [BindProperty]
        public Tarea tarea{ get; set; }
        public async Task<IActionResult> OnGet()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _pedidolist = await _pedidoService.GetPedidosAsync();
            this.pedidolist = _pedidolist;
            var _empleadolist = await _empleadoService.GetEmpleadosAsync();
            this.empleadolist = _empleadolist;
            return Page();
        }
        public IEnumerable<Pedido> pedidolist;
        public IEnumerable<Empleado> empleadolist;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            var res = await _tareaService.AddTareaAsync(this.tarea);
            if (res)
                return RedirectToPage("/pagina/Tareas/Index");
            else
                return Page();            
        }
    }
}

