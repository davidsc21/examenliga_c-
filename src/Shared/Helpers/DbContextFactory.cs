using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examenliga_c.src.Shared.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace examenliga_c.src.Shared.Helpers
{
    public class DbContextFactory
    {
        public static AppdbContext Create()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
            string? connectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION")
                            ?? config.GetConnectionString("MySqlDB");

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("No se encontró una cadena de conexión válida.");
            // Detectar version MySQL
            var detectedVersion = MySqlVersionResolver.DetectVersion(connectionString);
            var minVersion = new Version(8, 0, 0);
            if (detectedVersion < minVersion)
                throw new NotSupportedException($"Version de MySQL no soportada: {detectedVersion}. Requiuere {minVersion} o superior.");
            var options = new DbContextOptionsBuilder<AppdbContext>()
                .UseMySql(connectionString, new MySqlServerVersion(detectedVersion))
                .Options;
            return new AppdbContext(options);
        }
    }
}