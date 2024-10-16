using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ENTITY
{
    public class Estatus
    {
        private int speed;            // Velocidad actual del auto
        private string direction;     // Dirección actual
        private int fuelLevel;        // Nivel de combustible
        private bool isEngineOn;      // Estado del motor
        private string musicPlaying;   // Canción o estación de radio actual

        public int Speed
        {
            get => speed;
            set
            {
                if (value < 0)
                    throw new ArgumentException("La velocidad no puede ser negativa.");
                speed = value;
            }
        }

        public string Direction
        {
            get => direction;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value != "Izquierda" && value != "Derecha" && value != "Recto")
                    throw new ArgumentException("La dirección debe ser 'Izquierda', 'Derecha' o 'Recto'.");
                direction = value;
            }
        }

        public int FuelLevel
        {
            get => fuelLevel;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("El nivel de combustible debe estar entre 0 y 100.");
                fuelLevel = value;
            }
        }

        public bool IsEngineOn
        {
            get => isEngineOn;
            set => isEngineOn = value;
        }

        public string MusicPlaying
        {
            get => musicPlaying;
            set => musicPlaying = value;  // No se aplican validaciones aquí, puedes expandir si lo deseas
        }

        public override string ToString()
        {
            return $"Speed: {Speed}, Direction: {Direction}, FuelLevel: {FuelLevel}, EngineOn: {IsEngineOn}, MusicPlaying: {MusicPlaying}";
        }
    }
}