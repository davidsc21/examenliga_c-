using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examenliga_c.src.modules.Torneos.Ui
{
    public class MenuTorneos
    {
        public void Mostrarmenutorneo()
        {
             Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║                🏆 MENÚ DE TORNEOS                  ║");
            Console.WriteLine("╠════════════════════════════════════════════════════╣");
            Console.WriteLine("║ 1. ➕ Añadir Torneo                                ║");
            Console.WriteLine("║ 2. 🔍 Buscar Torneo                                ║");
            Console.WriteLine("║ 3. ❌ Eliminar Torneo                              ║");
            Console.WriteLine("║ 4. ✏️  Actualizar Torneo                            ║");
            Console.WriteLine("║ 5. 🔙 Regresar al Menú Principal                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.Write("👉 Opción: ");      
        }
            
    }
}