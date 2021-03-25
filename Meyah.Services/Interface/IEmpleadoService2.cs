using Meyah.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meyah.Services.Interface
{
    public interface IEmpleadoService2
    {
        Task<Empleado> GetEmpleadoAsync(int id);
    }
}
