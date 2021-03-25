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
    public class TareaService : ITareaService
    {
        private HttpClient _client;
        public TareaService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://meyah.somee.com/Api/tarea/");
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        public async Task<IEnumerable<Tarea>> GetTareasAsync()
        {
            var resStr = await _client.GetStringAsync("");
            tareaList ArrP = JsonConvert.DeserializeObject<tareaList>(resStr);
            List<Tarea> Listtarea = new List<Tarea>();
            for (int i = 0; i < ArrP.data.Count; i++)
            {
                Listtarea.Add(new Tarea { 
                    tareaId = ArrP.data[i].tareaId,
                    descripcion = ArrP.data[i].descripcion,
                    fechaentrega = ArrP.data[i].fechaentrega,
                    fechainicio = ArrP.data[i].fechainicio,
                    creado = ArrP.data[i].creado,
                    modificado = ArrP.data[i].modificado,
                    pedidoId = ArrP.data[i].pedidoId,
                    empleadoId = ArrP.data[i].empleadoId
                });
            }
            IEnumerable<Tarea> INumTarea = Listtarea;
            return INumTarea;
        }
        public async Task<Tarea> GetTareaAsync(int id)
        {

            var resStr = await _client.GetStringAsync("" + id);
            tareaData tarea = JsonConvert.DeserializeObject<tareaData>(resStr);
            List<Tarea> Listtarea = new List<Tarea>();
            Listtarea.Add(new Tarea { 
                tareaId = tarea.data.tareaId,
                descripcion = tarea.data.descripcion,
                fechainicio = tarea.data.fechainicio,
                fechaentrega = tarea.data.fechaentrega,
                creado = tarea.data.creado,
                modificado = tarea.data.modificado,
                pedidoId = tarea.data.pedidoId,
                empleadoId = tarea.data.empleadoId,

            });
            Tarea tarea1 = Listtarea[0];
            return tarea1;

        }
        public async Task<bool> AddTareaAsync(Tarea tarea)
        {
            var json =
                "{\"descripcion\": \"" + tarea.descripcion +
                "\",\"fechainicio\":\"" + tarea.fechainicio.Date.ToString().Substring(6, 4) + "-" + tarea.fechainicio.Date.ToString().Substring(3, 2) + "-" + tarea.fechainicio.Date.ToString().Substring(0, 2) +
                "\",\"fechaentrega\":\"" + tarea.fechaentrega.Date.ToString().Substring(6, 4) + "-" + tarea.fechaentrega.Date.ToString().Substring(3, 2) + "-" + tarea.fechaentrega.Date.ToString().Substring(0, 2) +
                "\",\"pedidoId\":" + tarea.pedidoId +
                ",\"empleadoId\":" + tarea.empleadoId +
                "}";
            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await _client.PostAsync("", cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteTareaAsync(int id)
        {

            var resStr = await _client.DeleteAsync("" + id);
            return resStr.IsSuccessStatusCode;

        } 

        public async Task<bool> UpdateTareaAsync(Tarea tarea, int id)
        {
            //Año - mes - dia
            var json =
               "{\"descripcion\": \"" + tarea.descripcion +                
                "\",\"fechaentrega\":\"" + tarea.fechaentrega.Date.ToString().Substring(6, 4) + "-" + tarea.fechaentrega.Date.ToString().Substring(3, 2) + "-" + tarea.fechaentrega.Date.ToString().Substring(0, 2) +
                "\",\"pedidoId\":" + tarea.pedidoId +
                ",\"empleadoId\":" + tarea.empleadoId +
                "}";

            HttpContent cJson = new StringContent(json, Encoding.UTF8, "application/json");
            var res = await _client.PutAsync("" + id, cJson);
            Console.WriteLine(res.IsSuccessStatusCode);
            Console.WriteLine(json);
            return res.IsSuccessStatusCode;
        }
        ~TareaService()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }
    }
}
