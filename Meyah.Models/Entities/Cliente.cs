using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meyah.Models.Entities
{
    public class Cliente
    {
        [JsonProperty("clienteId")]
        public int clienteId { get; set; }
        [JsonProperty("nombrecl")]
        public string nombrecl { get; set; }
        [JsonProperty("apellidocl")]
        public string apellidocl { get; set; }
        [JsonProperty("nacimiento")]
        public DateTime nacimiento { get; set; }
        [JsonProperty("direccion")]
        public string direccion { get; set; }
        [JsonProperty("telefono")]
        public string telefono { get; set; }
        [JsonProperty("creado")]
        public DateTime creado { get; set; }
        [JsonProperty("modificado")]
        public DateTime? modificado { get; set; }
        [JsonProperty("usuarioId")]
        public int usuarioId { get; set; }
    }
    public class ClienteList
    {
        [JsonProperty("data")]
        public List<Cliente> data { get; set; }
    }
    public class ClienteData
    {
        [JsonProperty("data")]
        public Cliente data { get; set; }
    }
}
