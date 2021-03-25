using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meyah.Models.Entities
{
    public class Tarea
    {
        [JsonProperty("tareaId")]
        public int  tareaId { get; set; }
        [JsonProperty("descripcion")]
        public string descripcion { get; set; }
        [JsonProperty("fechainicio")]
        public DateTime fechainicio { get; set; }
        [JsonProperty("fechaentrega")]
        public DateTime fechaentrega { get; set; }
        [JsonProperty("creado")]
        public DateTime creado { get; set; }
        [JsonProperty("modificado")]
        public DateTime? modificado { get; set; }
        [JsonProperty("pedidoId")]
        public int pedidoId { get; set; }
        [JsonProperty("empleadoId")]
        public int empleadoId { get; set; }
    }
    public class tareaList
    {
        [JsonProperty("data")]
        public List<Tarea> data { get; set; }
    }
    public class tareaData
    {
        [JsonProperty("data")]
        public Tarea data { get; set; }
    }
}
