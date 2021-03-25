using Meyah.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meyah.Services.Interface
{
    public interface IUsuarioService2
    {
        Task<Usuario> GetUsuarioAsync(int id);
        Task<bool> AddUsuario(Usuario usuario);
        Task<bool> UpdateUsuarioAsync(Usuario usuario);
    }
}
