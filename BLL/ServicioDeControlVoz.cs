using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioDeControlVoz
    {
        private readonly GestorDeAutomovil _gestorDeAutomovil;

        public ServicioDeControlVoz(GestorDeAutomovil gestorDeAutomovil)
        {
            _gestorDeAutomovil = gestorDeAutomovil;
        }

        public void EjecutarComando(string comando)
        {
            // Ejemplo de procesamiento de comandos
            if (comando.StartsWith("iniciar motor"))
            {
                _gestorDeAutomovil.IniciarAutomovil();
            }
            else if (comando.StartsWith("detener motor"))
            {
                _gestorDeAutomovil.DetenerAutomovil();
            }
            else if (comando.StartsWith("mover"))
            {
                // Supongamos que el comando tiene el formato "mover 10 5"
                var partes = comando.Split(' ');
                if (partes.Length == 4 &&
                    float.TryParse(partes[1], out float deltaX) &&
                    float.TryParse(partes[2], out float deltaY))
                {
                    _gestorDeAutomovil.MoverAutomovil(deltaX, deltaY);
                }
            }
            else if (comando.StartsWith("controlar luces"))
            {
                // Lógica para controlar luces
            }
            else if (comando.StartsWith("controlar radio"))
            {
                // Lógica para controlar la radio
            }
            else if (comando.StartsWith("controlar musica"))
            {
                // Lógica para controlar la música
            }
            // Agregar más comandos según sea necesario
        }
    }
}
