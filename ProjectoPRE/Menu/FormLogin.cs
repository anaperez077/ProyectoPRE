using ProjectoPRE.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPRE
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            // Pasamos "Admin" al Home
            FormHome home = new FormHome("Admin");
            home.Show();
            this.Hide();
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {
            // Pasamos "Empleado" al Home
            FormHome home = new FormHome("Empleado");
            home.Show();
            this.Hide();
        }
    }
}
