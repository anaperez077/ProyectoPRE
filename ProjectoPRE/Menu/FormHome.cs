using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPRE.Menu
{
    public partial class FormHome : Form
    {
        private string rolUsuario;

        // IMPORTANTE: El constructor ahora recibe el rol
        public FormHome(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (rolUsuario == "Admin")
            {
                panelNavegacion.BackColor = Color.LightCoral; // Rojo
                lblTituloDashboard.Text = "Dashboard de Administrador";
            }
            else
            {
                panelNavegacion.BackColor = Color.LightGreen; // Verde
                lblTituloDashboard.Text = "Dashboard de Empleado";
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Abrimos tu inventario y le pasamos el rol
            Inventario frm = new Inventario(rolUsuario);
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas frm = new Ventas(rolUsuario);
            frm.ShowDialog();
        }

        private void lblTituloDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
