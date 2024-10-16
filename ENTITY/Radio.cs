using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Radio
    {
        public int Volumen { get; set; }
        public string Estacion { get; set; }

        public Radio()
        {
            Volumen = 10; // Volumen inicial
            Estacion = "FM 100.0"; // Estación inicial
        }

        public void CambiarEstacion(string estacion)
        {
            Estacion = estacion;
        }

        public void AjustarVolumen(int volumen)
        {
            Volumen = volumen;
        }
    }
}
