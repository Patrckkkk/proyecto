using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using ENTITY;
namespace DALL
{
   

    public class RepositorioDeConfiguracionesDeUsuario
    {
        private const string archivoConfiguraciones = "configuraciones.json";
        private ConfiguracionesDeUsuario configuracion;

        public RepositorioDeConfiguracionesDeUsuario()
        {
            configuracion = CargarConfiguracion();
        }

        public void AgregarConfiguracion(ConfiguracionesDeUsuario configuracion)
        {
            this.configuracion = configuracion;
            GuardarConfiguracionesDeUsuario();
        }

        public ConfiguracionesDeUsuario ObtenerConfiguracionesDeUsuario()
        {
            return configuracion;
        }

        public void GuardarConfiguracionesDeUsuario()
        {
            File.WriteAllText(archivoConfiguraciones, JsonConvert.SerializeObject(configuracion, Formatting.Indented));
        }

        private ConfiguracionesDeUsuario CargarConfiguracion()
        {
            if (File.Exists(archivoConfiguraciones))
            {
                var json = File.ReadAllText(archivoConfiguraciones);
                return JsonConvert.DeserializeObject<ConfiguracionesDeUsuario>(json) ?? new ConfiguracionesDeUsuario();
            }
            return new ConfiguracionesDeUsuario();
        }
    }
}
