using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Newtonsoft.Json;

namespace Meyah.Services.Service
{
    public class ProductoService : IProductoService
    {
        private HttpClient _client;
        public ProductoService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://meyah.somee.com/Api/producto/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Producto>> GetProductosAsync()
        {
            var resStr = await _client.GetStringAsync("");
            ProductoList ArrP = JsonConvert.DeserializeObject<ProductoList>(resStr);
            List<Producto> ListPrdo = new List<Producto>();
            for (int i = 0; i < ArrP.data.Count; i++)
            {
                ListPrdo.Add(new Producto { productoId = ArrP.data[i].productoId, nombreprod = ArrP.data[i].nombreprod, precio = ArrP.data[i].precio });
            }
            IEnumerable<Producto> INumProd = ListPrdo;
            return INumProd;
        }
        public async Task<Producto> GetProductoAsync(int id)
        {

            var resStr = await _client.GetStringAsync("" + id);
            ProductoData Prod = JsonConvert.DeserializeObject<ProductoData>(resStr);
            List<Producto> ListProd = new List<Producto>();
            ListProd.Add(new Producto { productoId = Prod.data.productoId, nombreprod = Prod.data.nombreprod, precio = Prod.data.precio });
            Producto producto = ListProd[0];
            return producto;
        }
        public async Task<bool> AddProducto(Producto producto)
        {
            var json =
                "{\"nombreprod\": \"" + producto.nombreprod + 
                "\",\"precio\": " + producto.precio + "}";
            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            return res.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteProductodAsync(int id)
        {

            var resStr = await _client.DeleteAsync("" + id);
            return resStr.IsSuccessStatusCode;

        }
        public async Task<bool> UpdateProductoAsync(Producto producto)
        {
            var json = 
                "{\"nombreprod\": \"" + producto.nombreprod + 
                "\",\"precio\": " + producto.precio + "}";
            HttpContent cjson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PutAsync("" + producto.productoId, cjson);
            Console.WriteLine(res.IsSuccessStatusCode);
            return res.IsSuccessStatusCode;
        }
        ~ProductoService()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }
    }
}
