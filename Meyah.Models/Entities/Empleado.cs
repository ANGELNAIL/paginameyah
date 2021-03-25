using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meyah.Models.Entities
{
    public class Empleado
    {
        [JsonProperty("empleadoId")]
        public int empleadoId { get; set; }
        [JsonProperty("nombreemp")]
        public string nombreemp { get; set; }
        [JsonProperty("apellidoem")]
        public string apellidoem { get; set; }
        [JsonProperty("creado")]
        public DateTime creado { get; set; }
        [JsonProperty("modificado")]
        public DateTime modificado { get; set; }
        [JsonProperty("usuarioId")]
        public int usuarioId { get; set; }
        [JsonProperty("telefono")]
        public string telefono { get; set; }
        [JsonProperty("fechanacimiento")]
        public DateTime fechanacimiento { get; set; }
    } 

    public class EmpleadoList
    {
        [JsonProperty("data")]
        public List<Empleado> data { get; set; }
    }
    public class EmpleadoData
    {
        [JsonProperty("data")]
        public Empleado data { get; set; }
    }
}
