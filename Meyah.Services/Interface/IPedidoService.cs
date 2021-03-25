using Meyah.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meyah.Services.Interface
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetPedidosAsync();
        Task<Pedido> GetPedidoAsync(int id);
        Task<bool> AddPedido(Pedido pedido);
        Task<bool> DeletePedidoAsync(int id);
        Task<bool> UpdatePedidoAsync(Pedido pedido);
    }
}
