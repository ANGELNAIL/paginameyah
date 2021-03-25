using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Meyah.Services.Interface;
using Meyah.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace Meyah.Pages.pagina
{
    public class LoginModel : PageModel
    {
        private readonly IUsuarioService _usuarioService;
        public LoginModel(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }
        [BindProperty]
        public Usuario usuario { get; set; }
        //public info info { get; set; }
        public async Task<IActionResult> OnPostAsync(Usuario usuario, string button)
        {
            if (!ModelState.IsValid)
                return Page();
            if (button == "Ingresar")
            {
                info res = await _usuarioService.GetUsuariosAsync(usuario);
                Console.WriteLine(res.msg);
                if (res.msg != null)
                {
                    HttpContext.Session.SetString("idUsuario", res.msg.usuarioId.ToString());
                    switch (res.msg.tipoId)
                    {
                        case 1:
                            return RedirectToPage("/pagina/Index");
                        //empleado
                        case 2:
                            return RedirectToPage("/pagina/Index");
                        //admin
                        case 3:
                            return RedirectToPage("/pagina/Index");
                            //cliente
                    }
                }
                /*if (res)
                    return RedirectToPage("/pagina/Login");        
                 Console.WriteLine(res.msg.email);
                */
            }
            return RedirectToPage("/pagina/Login");
        }
    }
}
