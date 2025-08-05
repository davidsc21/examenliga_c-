using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examenliga.src.modules.Domain.Entities;

public class Torneo
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    public string? Tipo { get; set; }

    public string? Pais { get; set; }
    public DateTime Creacion = DateTime.Now;
    public int? Prize { get; set; }
}