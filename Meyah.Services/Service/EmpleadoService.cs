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
    public class EmpleadoService :IEmpleadoService
    {
        private HttpClient _client;
        public EmpleadoService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://meyah.somee.com/Api/Empleado/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Empleado>> GetEmpleadosAsync()
        {
            var resStr = await _client.GetStringAsync("");
            EmpleadoList ArrP = JsonConvert.DeserializeObject<EmpleadoList>(resStr);
            List<Empleado> Listemleado = new List<Empleado>();
            for (int i = 0; i < ArrP.data.Count; i++)
            {
                Listemleado.Add(new Empleado { 
                    empleadoId = ArrP.data[i].empleadoId,
                    nombreemp = ArrP.data[i].nombreemp,
                    apellidoem = ArrP.data[i].apellidoem,
                    telefono = ArrP.data[i].telefono,
                    fechanacimiento = ArrP.data[i].fechanacimiento,
                    creado = ArrP.data[i].creado,
                    modificado = ArrP.data[i].modificado,
                    usuarioId = ArrP.data[i].usuarioId
                }); 
            }
            IEnumerable<Empleado> INumEmp = Listemleado;
            return INumEmp;
        }
        public async Task<Empleado> GetEmpleadoAsync(int id)
        {
            var resStr = await _client.GetStringAsync("" + id);
            EmpleadoData emp = JsonConvert.DeserializeObject<EmpleadoData>(resStr);
            List<Empleado> ListEmp = new List<Empleado>();
            ListEmp.Add(new Empleado
            {
                empleadoId = emp.data.empleadoId,
                nombreemp = emp.data.nombreemp,
                apellidoem = emp.data.apellidoem,
                telefono = emp.data.telefono,
                fechanacimiento = emp.data.fechanacimiento,
                creado = emp.data.creado,
                usuarioId = emp.data.usuarioId,                
                modificado = emp.data.modificado
            });
            Empleado empleado = ListEmp[0];
            return empleado;
        }        
        public async Task<bool> AddEmpleado(Empleado empleado)
        {
            var json =               
                "{\"nombreemp\":\""  + empleado.nombreemp +
                "\",\"apellidoem\":\"" + empleado.apellidoem +
                "\",\"fechanacimiento\":\"" + empleado.fechanacimiento.Date.ToString().Substring(6, 4) + "-" + empleado.fechanacimiento.Date.ToString().Substring(3, 2) + "-" + empleado.fechanacimiento.Date.ToString().Substring(0, 2) +
                "\",\"telefono\":\"" + empleado.telefono +
                "\",\"usuarioId\": " + empleado.usuarioId + "}";
            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteEmpleadoAsync(int id)
        {

            var resStr = await _client.DeleteAsync("" + id);
            return resStr.IsSuccessStatusCode;

        }

        public async Task<bool> UpdateEmpleadoAsync(Empleado empleado)
        {
            var json =
                "{\"nombreemp\":\"" + empleado.nombreemp +
                "\",\"apellidoem\":\"" + empleado.apellidoem +
                "\",\"fechanacimiento\":\"" + empleado.fechanacimiento.Date.ToString().Substring(6, 4) + "-" + empleado.fechanacimiento.Date.ToString().Substring(3, 2) + "-" + empleado.fechanacimiento.Date.ToString().Substring(0, 2) +
                "\",\"telefono\":\"" + empleado.telefono +"\"" + "}";
            HttpContent cjson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PutAsync("" + empleado.empleadoId, cjson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }

        ~EmpleadoService()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }

    }
}
