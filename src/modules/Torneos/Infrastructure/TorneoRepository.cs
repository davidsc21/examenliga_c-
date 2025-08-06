using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examenliga_c.src.modules.Torneos.Application.Interfaces;
using examenliga_c.src.modules.Torneos.Domain.Entities;
using examenliga_c.src.Shared.Context;
using Microsoft.EntityFrameworkCore;

namespace examenliga_c.src.modules.Torneos.Infrastructure
{
    public class TorneoRepository
    {
        private readonly AppdbContext _context;

        public TorneoRepository(AppdbContext context)
        {
            _context = context;
        }

        public async Task<Torneo?> GetByIdAsync(int id)
        {
            return await _context.Torneos
            .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<IEnumerable<Torneo?>> GetTorneosAsync() =>
            await _context.Torneos.ToListAsync();
        public void Add(Torneo entity) =>
            _context.Torneos.Add(entity);
        public void Remove(Torneo entity) =>
            _context.Torneos.Remove(entity);
        public void Update(Torneo entity) =>
            _context.SaveChanges();
        public async Task SaveAsync() =>
        await _context.SaveChangesAsync();
    }
}