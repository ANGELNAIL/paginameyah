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
    class UsuarioService2 :  IUsuarioService2
    {
        private HttpClient _client;
        public UsuarioService2()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://meyah.somee.com/Api/usuario/1");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }       
        public async Task<Usuario> GetUsuarioAsync(int id)
        {
            var resStr = await _client.GetStringAsync("" + id);
            UsuarioData Usr = JsonConvert.DeserializeObject<UsuarioData>(resStr);
            List<Usuario> ListUser = new List<Usuario>();
            ListUser.Add(new Usuario
            {
                email = Usr.data.email,
                contraseña = Usr.data.contraseña               
            });
            Usuario usuario = ListUser[0];
            return usuario;
        }
        ~UsuarioService2()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }
        public async Task<bool> AddUsuario(Usuario usuario)
        {
            var json =
                 "{\"email\":\"" + usuario.email +
                 "\",\"contraseña\":\"" + usuario.contraseña + "\"" +
                 "}";

            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteUsuarioAsync(int id)
        {
            var resStr = await _client.DeleteAsync("" + id);
            return resStr.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateUsuarioAsync(Usuario usuario)
        {
            var json =
               "{\"email\":\"" + usuario.email +
                 "\",\"contraseña\":\"" + usuario.contraseña + "\"" +
                 "}";
            HttpContent cjson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PutAsync("" + usuario.usuarioId, cjson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }
    }
}

