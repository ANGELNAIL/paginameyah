using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meyah.Models.Entities
{
    public class Producto
    {
        [JsonProperty("productoId")]
        public int productoId { get; set; }
        [JsonProperty("nombreprod")]
        public string nombreprod { get; set; }
        [JsonProperty("precio")]
        public double precio { get; set; }
    }

    public class  ProductoList
    {
        [JsonProperty("data")]
        public List<Producto> data { get; set; }
    }
    public class ProductoData
    {
        [JsonProperty("data")]
        public Producto data { get; set; }
    }
}
