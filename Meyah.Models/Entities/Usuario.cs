using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meyah.Models.Entities
{
    public class Usuario
    {
        [JsonProperty("usuarioId")]
        public int usuarioId { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("contraseña")]
        public string contraseña { get; set; }
        [JsonProperty("tipoId")]
        public int tipoId { get; set; }

    }
    public class UsuarioList
    {
        [JsonProperty("data")]
        public List<Usuario> data { get; set; }
    }
    public class UsuarioData
    {
        [JsonProperty("data")]
        public Usuario data { get; set; }
    }
    public class info
    {
        public bool ok { get; set; }
        public Usuario? msg { get; set; }
    }
}
