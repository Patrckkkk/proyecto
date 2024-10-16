using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoAula
{
    using System;
    using System.Windows.Forms;

    public partial class FormularioPrincipal : Form
    {
        private readonly ServicioDeControlVoz servicioDeControlVoz;

        public FormularioPrincipal()
        {
            InitializeComponent();
            var repositorioAutomovil = new RepositorioDeAutomovil();
            var repositorioConfiguraciones = new RepositorioDeConfiguracionesDeUsuario();
            var gestorAutomovil = new GestorDeAutomovil(repositorioAutomovil, "MI_PLACA"); // Cambia a la placa deseada
            servicioDeControlVoz = new ServicioDeControlVoz(gestorAutomovil);
        }

        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            string comando = EscucharComando(); // Método para escuchar el comando de voz
            ProcesarComando(comando);
        }

        private void ProcesarComando(string comando)
        {
            servicioDeControlVoz.EjecutarComando(comando);
            MostrarEstado(); // Actualiza la interfaz según el estado actual
        }

        private string EscucharComando()
        {
            // Aquí va la lógica para capturar el comando de voz
            // Esto puede ser una integración con una API de reconocimiento de voz
            return "iniciar motor"; // Ejemplo estático
        }

        private void MostrarEstado()
        {
            // Lógica para mostrar el estado del automóvil
            if (servicioDeControlVoz is GestorDeAutomovil gestor)
            {
                lblEstadoMotor.Text = gestor.EstaMotorEncendido ? "Motor Encendido" : "Motor Apagado";
            }
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            MostrarEstado(); // Muestra el estado al cargar el formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
