using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using examenliga_c.src.modules.Torneos.Domain.Entities;

namespace examenliga_c.src.modules.Torneos.Application.Interfaces
{
    public interface ITorneoService
    {
        Task RegistrarTorneoConTareaAsync(string nombre, string email);
        Task ActualizarTorneo(int id, string nuevoNombre, string nuevoEmail);
        Task EliminarTorneo(int id);
        Task<Torneo?> ObtenerTorneoPorIdAsync(int id);
        Task<IEnumerable<Torneo>> ConsultarTorneosAsync();
    }
}