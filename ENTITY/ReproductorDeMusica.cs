using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    using System.Collections.Generic;

    public class ReproductorDeMusica
    {
        public List<string> ListaDeReproduccion { get; set; }
        public int PistaActual { get; set; }

        public ReproductorDeMusica()
        {
            ListaDeReproduccion = new List<string>();
            PistaActual = 0;
        }

        public void ReproducirPista(int pistaIndex)
        {
            if (pistaIndex >= 0 && pistaIndex < ListaDeReproduccion.Count)
            {
                PistaActual = pistaIndex;
                // Lógica para reproducir la pista
            }
        }

        public void Pausar()
        {
            // Lógica para pausar la reproducción
        }

        public void SiguientePista()
        {
            if (PistaActual < ListaDeReproduccion.Count - 1)
            {
                PistaActual++;
                // Lógica para reproducir la siguiente pista
            }
        }
    }

}
