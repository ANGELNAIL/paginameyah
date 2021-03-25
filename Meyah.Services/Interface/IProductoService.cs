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
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetProductosAsync();
        Task<Producto> GetProductoAsync(int id);
        Task<bool> AddProducto(Producto producto);
        Task<bool> DeleteProductodAsync(int id);
        Task<bool> UpdateProductoAsync(Producto producto);
    }
}
