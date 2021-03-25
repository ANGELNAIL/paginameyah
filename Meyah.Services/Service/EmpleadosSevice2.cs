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
    class EmpleadosSevice2 : IEmpleadoService2
    {
        private HttpClient _client;
        public EmpleadosSevice2()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:3000/empleado/1");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
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
    }
}
