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
    public class ClienteService : IClienteService
    {
        private HttpClient _client;
        public ClienteService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://meyah.somee.com/Api/cliente/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
    
        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            var resStr = await _client.GetStringAsync("");
            ClienteList ArrP = JsonConvert.DeserializeObject<ClienteList>(resStr);
            List<Cliente> ListClient = new List<Cliente>();
            for (int i = 0; i < ArrP.data.Count; i++)
            {
                ListClient.Add(new Cliente { 
                    clienteId = ArrP.data[i].clienteId,
                    nombrecl = ArrP.data[i].nombrecl,
                    apellidocl = ArrP.data[i].apellidocl,
                    nacimiento = ArrP.data[i].nacimiento,
                    modificado = ArrP.data[i].modificado,
                    usuarioId = ArrP.data[i].usuarioId,
                    direccion = ArrP.data[i].direccion,
                    telefono = ArrP.data[i].telefono,
                    creado = ArrP.data[i].creado  });
            }
            IEnumerable<Cliente> INumClient = ListClient;
            return INumClient;
        }
        public async Task<Cliente> GetClienteAsync(int id)
        {
            var resStr = await _client.GetStringAsync("" + id);
            ClienteData cli = JsonConvert.DeserializeObject<ClienteData>(resStr);
            List<Cliente> ListClie = new List<Cliente>();
            ListClie.Add(new Cliente
            {
                clienteId = cli.data.clienteId,
                nombrecl = cli.data.nombrecl,
                apellidocl = cli.data.apellidocl,
                nacimiento = cli.data.nacimiento,
                modificado = cli.data.modificado,
                creado = cli.data.creado,
                usuarioId = cli.data.usuarioId,
                direccion = cli.data.direccion,
                telefono = cli.data.telefono
            });
            Cliente cliente = ListClie[0];
            return cliente;
        }
        ~ClienteService()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }
        public async Task<bool> Addcliente(Cliente cliente)
        {
            var json =
                 "{\"nombrecl\":\"" + cliente.nombrecl +
                 "\",\"apellidocl\":\"" + cliente.apellidocl +
                 "\",\"nacimiento\":\"" + cliente.nacimiento.Date.ToString().Substring(6, 4) + "-" + cliente.nacimiento.Date.ToString().Substring(3, 2) + "-" + cliente.nacimiento.Date.ToString().Substring(0, 2) +
                 "\",\"direccion\":\"" + cliente.direccion +
                 "\",\"telefono\":\"" + cliente.telefono +
                 "\",\"usuarioId\":" + cliente.usuarioId +
                 "}";

            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteClienteAsync(int id)
        {

            var resStr = await _client.DeleteAsync("" + id);
            return resStr.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateClienteAsync(Cliente cliente)
        {
            var json =
               "{\"nombrecl\":\"" + cliente.nombrecl +
                 "\",\"apellidocl\":\"" + cliente.apellidocl +
                 "\",\"nacimiento\":\"" + cliente.nacimiento.Date.ToString().Substring(6, 4) + "-" + cliente.nacimiento.Date.ToString().Substring(3, 2) + "-" + cliente.nacimiento.Date.ToString().Substring(0, 2) +
                 "\",\"direccion\":\"" + cliente.direccion +
                 "\",\"telefono\":\"" + cliente.telefono +
                 "\",\"usuarioId\":" + cliente.usuarioId +
                 "}";
            HttpContent cjson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PutAsync("" + cliente.clienteId, cjson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }       
    }
}
