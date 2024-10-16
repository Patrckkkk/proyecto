using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ENTITY
{
    public class ComandoVoz
    {
        public string Command { get; set; }       // Comando de voz recibido (Ej.: "acelerar", "frenar")
        public DateTime Timestamp { get; set; }   // Fecha y hora en que se ejecutó el comando
        public string Result { get; set; }        // Resultado del comando (opcional, Ej.: "Aceleración exitosa")

        public override string ToString()
        {
            return $"Command: {Command}, Timestamp: {Timestamp}, Result: {Result}";
        }
    }
}
