using Meyah.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Meyah.Services.Interface
{
    public interface IUsuarioService
    {
        Task<info> GetUsuariosAsync(Usuario usuario);
    }
}
