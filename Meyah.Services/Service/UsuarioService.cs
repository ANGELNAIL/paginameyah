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
    public class UsuarioService : IUsuarioService
    {
        private HttpClient _client;
        public UsuarioService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://nodepruebaapi.herokuapp.com/login");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<info> GetUsuariosAsync(Usuario usuario)
        {
            var json =
               "{\"email\": \"" + usuario.email +
               "\",\"password\":\"" + usuario.contraseña  + "\"" +              
               "}";
            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            info ArrP = JsonConvert.DeserializeObject<info>(await res.Content.ReadAsStringAsync());
            /*regresa el estatus de lo enviado
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(ArrP.msg.usuarioId);
            Console.WriteLine(json);
            */
            return ArrP;
        }
    }
}
