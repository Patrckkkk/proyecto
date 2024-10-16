using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Automovil(string modelo, string placa)
    {
        public string Modelo { get; set; } = modelo;
        public string Placa { get; set; } = placa;
        public bool EstaMotorEncendido { get; set; } = false;
        public float PosicionX { get; set; } = 0;
        public float PosicionY { get; set; } = 0;

        public void IniciarMotor()
        {
            EstaMotorEncendido = true;
        }

        public void DetenerMotor()
        {
            EstaMotorEncendido = false;
        }

        public void Mover(float deltaX, float deltaY)
        {
            PosicionX += deltaX;
            PosicionY += deltaY;
        }
    }
}
