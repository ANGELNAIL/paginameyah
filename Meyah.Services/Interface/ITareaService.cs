using Meyah.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meyah.Services.Interface
{
    public interface ITareaService
    {
        Task<IEnumerable<Tarea>> GetTareasAsync();
        Task<Tarea> GetTareaAsync(int id);
        Task<bool> AddTareaAsync(Tarea tarea);
        Task<bool> DeleteTareaAsync(int id);
        Task<bool> UpdateTareaAsync(Tarea tarea, int id);
    }
}
