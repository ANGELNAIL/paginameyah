using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina
{
    public class IndexModel : PageModel
    {
        public IActionResult Onget()
        {
            if (HttpContext.Session.GetString("idUsuario") == null)
            {
                return new RedirectToPageResult("/Pagina/Login");
            }
            string dato = HttpContext.Session.GetString("idUsuario".ToString());
            int id = Int32.Parse(dato);

            return Page();
        }
    }
}
