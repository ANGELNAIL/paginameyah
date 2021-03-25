using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meyah.Models.Entities
{
    public class Pedido
    {
        [JsonProperty("pedidoId")]
        public int pedidoId { get; set; }
        [JsonProperty("fechapedido")]
        public DateTime fechapedido { get; set; }
        [JsonProperty("fechaentrega")]
        public DateTime fechaentrega { get; set; }
        [JsonProperty("cantidad")]
        public int cantidad { get; set; }
        [JsonProperty("precio")]
        public double precio { get; set; }
        [JsonProperty("productoId")]
        public int productoId { get; set; }
        [JsonProperty("clienteId")]
        public int clienteId { get; set; }
        [JsonProperty("estado")]
        public bool estado { get; set; }
        [JsonProperty("modificado")]
        public DateTime? modificado { get; set; }
    }
    public class PedidoList
    {
        [JsonProperty("data")]
        public List<Pedido> data { get; set; }
    }
    public class PedidoData
    {
        [JsonProperty("data")]
        public Pedido data { get; set; }
    }
}
