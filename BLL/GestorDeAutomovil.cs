using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorDeAutomovil
    {
        private readonly RepositorioDeAutomovil repositorioDeAutomovil;
        private readonly Automovil automovil;

        public GestorDeAutomovil(RepositorioDeAutomovil repositorio, string placa)
        {
            repositorioDeAutomovil = repositorio;
            automovil = repositorioDeAutomovil.ObtenerDatosDelAutomovil(placa) ?? new Automovil("ModeloEjemplo", placa);
        }

        public void IniciarAutomovil()
        {
            if (!automovil.EstaMotorEncendido)
            {
                automovil.IniciarMotor();
                repositorioDeAutomovil.GuardarEstadoDelAutomovil(automovil);
            }
        }

        public void DetenerAutomovil()
        {
            if (automovil.EstaMotorEncendido)
            {
                automovil.DetenerMotor();
                repositorioDeAutomovil.GuardarEstadoDelAutomovil(automovil);
            }
        }

        public void MoverAutomovil(float deltaX, float deltaY)
        {
            if (automovil.EstaMotorEncendido)
            {
                automovil.Mover(deltaX, deltaY);
                repositorioDeAutomovil.GuardarEstadoDelAutomovil(automovil);
            }
        }

        public static void ControlarLuces(bool estado)
        {
            // Lógica para controlar las luces
        }

        public static void ControlarRadio(string estacion)
        {
            // Lógica para controlar la radio
        }

        public static void ControlarMusica(string pista)
        {
            // Lógica para controlar la música
        }
    }
}
