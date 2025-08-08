using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using examenliga_c.src.modules.Torneos.Application.Interfaces;
using examenliga_c.src.modules.Torneos.Domain.Entities;

namespace examenliga_c.src.modules.Torneos.Application.Services
{
    
}
public class TorneoService : ITorneoService
{
    private readonly ITorneoRepository _repo;
    public TorneoService(ITorneoRepository repo)
    {
        _repo = repo;
    }

    public Task<IEnumerable<Torneo>> ConsultarTorneosAsync()
    {
        return _repo.GetAllAsync();
    }

    public async Task RegistrarTorneoConTareaAsync(string nombre, string tipo)
    {
        var existentes = await _repo.GetAllAsync();
        if (existentes.Any(t => t.Name == nombre))
            throw new Exception("El torneo ya existe");

        var torneo = new Torneo
        {
            Name = nombre,
            Tipo = tipo
        };

        _repo.Add(torneo);
        _repo.Update(torneo);
    }

    public async Task ActualizarTorneo(int id, string nuevoNombre, string nuevoTipo)
    {
        var torneo = await _repo.GetByIdAsync(id);
        if (torneo == null)
            throw new Exception($"Torneo con ID {id} no encontrado.");
        torneo.Name = nuevoNombre;
        torneo.Tipo = nuevoTipo;

        _repo.Update(torneo);
        await _repo.SaveAsync();
    }

    public async Task EliminarTorneo(int id)
    {
        var torneo = await _repo.GetByIdAsync(id);
        if (torneo == null)
            throw new Exception($"Torneo con ID{id} no encontrado");
        _repo.Remove(torneo);
        await _repo.SaveAsync();
    }

    public async Task<Torneo?> ObtenerTorneoPorIdAsync(int id)
    {
        return await _repo.GetByIdAsync(id);
    }
}