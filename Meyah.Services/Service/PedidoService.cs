using Meyah.Models.Entities;
using Meyah.Services.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Meyah.Services.Service
{
    public class PedidoService :IPedidoService
    {
        private HttpClient _client;
        public PedidoService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://meyah.somee.com/Api/Pedido/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Pedido>> GetPedidosAsync()
        {
            var resStr = await _client.GetStringAsync("");
            PedidoList ArrP = JsonConvert.DeserializeObject<PedidoList>(resStr);
            List<Pedido> Listpedido = new List<Pedido>();
            for (int i = 0; i < ArrP.data.Count; i++)
            {
                Listpedido.Add(new Pedido
                {
                    pedidoId = ArrP.data[i].pedidoId,
                    fechaentrega = ArrP.data[i].fechaentrega,
                    fechapedido = ArrP.data[i].fechapedido,
                    cantidad = ArrP.data[i].cantidad,
                    precio = ArrP.data[i].precio,
                    productoId = ArrP.data[i].productoId,
                    clienteId = ArrP.data[i].clienteId,
                    estado = ArrP.data[i].estado,
                    modificado = ArrP.data[i].modificado
                });
            }
            IEnumerable<Pedido> INumPedido = Listpedido;
            return INumPedido;
        }
        public async Task<Pedido> GetPedidoAsync(int id)
        {
            var resStr = await _client.GetStringAsync("" + id);
            PedidoData ped = JsonConvert.DeserializeObject<PedidoData>(resStr);
            List<Pedido> ListPed = new List<Pedido>();
            ListPed.Add(new Pedido { 
                pedidoId = ped.data.pedidoId,
                fechaentrega = ped.data.fechaentrega,
                fechapedido = ped.data.fechapedido,
                cantidad = ped.data.cantidad,
                precio = ped.data.precio,
                productoId = ped.data.productoId,
                clienteId = ped.data.clienteId,
                estado = ped.data.estado,
                modificado = ped.data.modificado
            });
            Pedido pedido = ListPed[0];
            return pedido;
        }
        public async Task<bool> AddPedido(Pedido pedido)
        {
           var json = 
                "{\"clienteId\":" + pedido.clienteId +
                ",\"fechaentrega\":\"" + pedido.fechaentrega.Date.ToString().Substring(6, 4) + "-" + pedido.fechaentrega.Date.ToString().Substring(3, 2) + "-" + pedido.fechaentrega.Date.ToString().Substring(0, 2) +
                "\",\"precio\": " + pedido.precio +
                //"\"fechapedido\": \"" + pedido.fechapedido + 
                //"\"fechaentrega\": \"" + pedido.fechaentrega + 
                ",\"cantidad\":" + pedido.cantidad +
                ",\"productoId\":" + pedido.productoId +
                //"\"estado\": \"" + pedido.estado +
                //"\"modificado\": \"" + pedido.modificado +
                "}";

            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            return res.IsSuccessStatusCode;
        }
        public async Task<bool> DeletePedidoAsync(int id)
        {

            var resStr = await _client.DeleteAsync("" + id);
            return resStr.IsSuccessStatusCode;

        }
        public async Task<bool> UpdatePedidoAsync(Pedido pedido)
        {
            //Año - mes - dia
            var json =
                "{\"clienteId\":" + pedido.clienteId +
                ",\"precio\": " + pedido.precio +
                ",\"fechapedido\": \"" + pedido.fechapedido.Date.ToString().Substring(6,4)+ "-"+ pedido.fechapedido.Date.ToString().Substring(3, 2)+ "-" + pedido.fechapedido.Date.ToString().Substring(0, 2) + 
                "\",\"fechaentrega\":\"" + pedido.fechaentrega.Date.ToString().Substring(6, 4) + "-" + pedido.fechaentrega.Date.ToString().Substring(3, 2) + "-" + pedido.fechaentrega.Date.ToString().Substring(0, 2) +
                "\",\"cantidad\":" + pedido.cantidad +
                ",\"productoId\":" + pedido.productoId +                
                "}";
           
            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PutAsync("" + pedido.pedidoId, cJson);
            return res.IsSuccessStatusCode;
        }
        ~PedidoService()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }
    }
}
