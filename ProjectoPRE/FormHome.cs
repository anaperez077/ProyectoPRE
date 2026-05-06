using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectoPRE
{
    public partial class FormHome : Form
    {
        // Variable para recordar quién entró
        private string rolUsuario;

        // Modificamos el constructor para que RECIBA el rol
        public FormHome(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            ConfigurarInterfazPorRol();
        }

        private void ConfigurarInterfazPorRol()
        {
            if (rolUsuario == "Admin")
            {
                // Estilo para Administración (Prototipo Rojo/Coral)
                panelNavegacion.BackColor = Color.LightCoral;
                lblTituloDashboard.Text = "Dashboard de Administrador";

                // Admin ve todo
                btnProveedores.Visible = true;
                btnProductos.Visible = true;
            }
            else
            {
                // Estilo para Empleados (Prototipo Verde)
                panelNavegacion.BackColor = Color.LightGreen;
                lblTituloDashboard.Text = "Dashboard de Empleado";

                // Empleado NO ve módulos sensibles
                btnProveedores.Visible = false;
                btnProductos.Visible = false;
            }
        }

        // BOTÓN QUE ABRE TU PARTE (Inventario)
        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Le pasamos el rol a tu form de inventario para que sepa si dejar borrar o no
            Inventario frmInv = new Inventario(rolUsuario);
            frmInv.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Aquí la Persona 2 conectará su Form
            MessageBox.Show("Módulo de Ventas (Persona 2)");
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            // Aquí la Persona 3 conectará su Form
            MessageBox.Show("Módulo de Proveedores (Persona 3)");
        }

        private void nave_Click(object sender, EventArgs e)
        {

        }
    }
}