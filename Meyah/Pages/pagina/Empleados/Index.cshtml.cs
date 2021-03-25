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
    public class IndexModel : PageModel
    {
        private readonly IEmpleadoService _EmpleadoService;
        public IndexModel(IEmpleadoService empleadoService)
        {
            this._EmpleadoService = empleadoService;
        }
        public IEnumerable<Empleado> EmpleadoList;

        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            var _empleadoList = await _EmpleadoService.GetEmpleadosAsync();
            this.EmpleadoList = _empleadoList;
            return Page();
        }
    }
}
