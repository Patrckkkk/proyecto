using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using ENTITY;
namespace DALL
{

    public class RepositorioDeAutomovil
    {
        private const string archivoAutomoviles = "automoviles.json";
        private readonly List<Automovil> automoviles;

        public RepositorioDeAutomovil()
        {
            automoviles = CargarAutomoviles();
        }

        public void AgregarAutomovil(Automovil automovil)
        {
            automoviles.Add(automovil);
            GuardarAutomoviles();
        }

        public Automovil ObtenerDatosDelAutomovil(string placa)
        {
            return automoviles.Find(a => a.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
        }

        public void GuardarEstadoDelAutomovil(Automovil automovil)
        {
            // Implementa la lógica específica para guardar el estado del automóvil.
            GuardarAutomoviles(); // Guarda la lista completa en el archivo.
        }

        private void GuardarAutomoviles()
        {
            File.WriteAllText(archivoAutomoviles, JsonConvert.SerializeObject(automoviles, Formatting.Indented));
        }

        private List<Automovil> CargarAutomoviles()
        {
            if (File.Exists(archivoAutomoviles))
            {
                var json = File.ReadAllText(archivoAutomoviles);
                return JsonConvert.DeserializeObject<List<Automovil>>(json) ?? new List<Automovil>();
            }
            return new List<Automovil>();
        }
    }

}
