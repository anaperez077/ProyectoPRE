using System;
using System.Windows.Forms;

namespace ProjectoPRE
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Evento para el botón de Administración (Color Rojo en prototipo)
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Creamos el Home y le pasamos el rol "Admin"
            FormHome home = new FormHome("Admin");
            home.Show();
            this.Hide(); // Escondemos el selector de perfil
        }

        // Evento para el botón de Empleados (Color Verde en prototipo)
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            // Creamos el Home y le pasamos el rol "Empleado"
            FormHome home = new FormHome("Empleado");
            home.Show();
            this.Hide(); // Escondemos el selector de perfil
        }

        private void Bienvenido_Click(object sender, EventArgs e)
        {

        }

        private void texto1_Click(object sender, EventArgs e)
        {

        }
    }
}