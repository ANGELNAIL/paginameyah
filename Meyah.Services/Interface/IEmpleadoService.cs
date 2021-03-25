using Meyah.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meyah.Services.Interface
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> GetEmpleadosAsync();
        Task<Empleado> GetEmpleadoAsync(int id);
        Task<bool> AddEmpleado(Empleado empleado);
        Task<bool> DeleteEmpleadoAsync(int id);
        Task<bool> UpdateEmpleadoAsync(Empleado empleado);
    }
}
