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
    public class IndexModel : PageModel
    {
        private readonly ITareaService _TareaService;
        private readonly IPedidoService _pedidoService;
        private readonly IEmpleadoService _empleadoService;
        public IndexModel(ITareaService tareaService, IEmpleadoService empleadoService, IPedidoService pedidoService)
        {
            this._TareaService = tareaService;         
        }
        public IEnumerable<Tarea> tareaList;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _tareaList = await _TareaService.GetTareasAsync();
            this.tareaList = _tareaList;
            return Page();
        }
    }
}
