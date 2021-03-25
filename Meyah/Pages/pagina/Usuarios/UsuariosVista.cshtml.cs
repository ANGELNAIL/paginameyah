using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Meyah.Pages.pagina.Usuarios
{
    public class UsuariosVistaModel : PageModel
    {
        private readonly IUsuarioService _UsuarioService;
        public UsuariosVistaModel(IUsuarioService usuarioService)
        {
            this._UsuarioService = usuarioService;
        }
        public IEnumerable<Usuario> UsuarioList;

        public async Task OnGetAsync()
        {
           
        }
    }
}
