using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class ConfiguracionesDeUsuario
    {
        public int Volumen { get; set; }
        public string EstacionPreferida { get; set; }

        public ConfiguracionesDeUsuario()
        {
            Volumen = 10; // Volumen por defecto
            EstacionPreferida = "FM 100.0"; // Estación preferida por defecto
        }
    }
}
