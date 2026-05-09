using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq.Expressions;

namespace ProjectoPRE
{
    public partial class AgregarProveedores : Form
    {

        public string idSeleccionado = null;
        public string IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor { get; set; }

        private string rolUsuario; // Para saber si es Admin o Empleado

        public AgregarProveedores(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
        }

        private void proveedoresAgregar_Load(object sender, EventArgs e)
        {
            // Si hay un ID seleccionado, estamos editando
            if (!string.IsNullOrEmpty(idSeleccionado))
            {
                textBox1.Text = NombreProveedor;
                textBox2.Text = TelefonoProveedor;
                textBox3.Text = idSeleccionado;
                textBox3.Enabled = false; // El ID no se toca porque es de la BD
                btnagregar2.Text = "Actualizar";
            }
            else
            {
                // Si es nuevo, limpiamos y bloqueamos el ID (la BD lo pondrá sola)
                textBox3.Text = "AUTO";
                textBox3.Enabled = false;
                btnagregar2.Text = "Guardar";
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnagregar2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, completa Nombre y Teléfono.");
                return;
            }

            string cadenaConexion = "Data Source=LibreriaSJ.db;Version=3;";
            string query;

            if (string.IsNullOrEmpty(idSeleccionado))
            {
                // INSERT sin el ID (porque es AUTOINCREMENT en tu BD)
                query = "INSERT INTO Proveedores (nombre_proveedor, telefono_proveedor) VALUES (@nombre, @telefono)";
            }
            else
            {
                // UPDATE usando el ID que ya tenemos
                query = "UPDATE Proveedores SET nombre_proveedor = @nombre, telefono_proveedor = @telefono WHERE id_proveedor = @id";
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", textBox1.Text);
                        comando.Parameters.AddWithValue("@telefono", textBox2.Text);

                        if (!string.IsNullOrEmpty(idSeleccionado))
                        {
                            comando.Parameters.AddWithValue("@id", idSeleccionado);
                        }

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Operación realizada con éxito!");
                this.DialogResult = DialogResult.OK; // ESTO ES LO QUE HACE QUE EL FORM ANTERIOR SE ACTUALICE
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
