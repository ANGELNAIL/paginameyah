using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Newtonsoft.Json;

namespace Meyah.Services.Interface
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> GetClienteAsync(int id);
        Task<bool> Addcliente(Cliente cliente);
        Task<bool> DeleteClienteAsync(int id);
        Task<bool> UpdateClienteAsync(Cliente cliente);
    }
}
