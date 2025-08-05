using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using examenliga_c.src.modules.Torneos.Domain.Entities;


namespace examenliga_c.src.modules.Torneos.Application.Interfaces
{
    public interface ITorneoRepository
    {
        Task<Torneo?> GetByIdAsync(int id);
        Task<IEnumerable<Torneo?>> GetAllAsync();
        void Add(Torneo entity);
        void Remove(Torneo entity);
        void Update(Torneo entity);
        Task SaveAsync();
    }
}