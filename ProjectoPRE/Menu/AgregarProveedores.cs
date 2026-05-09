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
    public partial class proveedoresAgregar : Form
    {

        public string idSeleccionado = null;
        public string IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor { get; set; }


        public proveedoresAgregar()
        {
            InitializeComponent();
        }

        private void proveedoresAgregar_Load(object sender, EventArgs e)
        {
            //si el ID no es nulo, entonces se esta editando
            if (!string.IsNullOrEmpty(IdProveedor))
            {
                textBox1.Text = NombreProveedor;
                textBox2.Text = TelefonoProveedor;
                btnagregar2.Text = "Actualizar"; //se cambia texto del boton
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
          
            this.Close();
            
        }

        private void btnagregar2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.");
                return; 
            }

            string cadenaConexion = "Data Source=LibreriaSJ.db;Version=3;";
            string query;

            if (string.IsNullOrEmpty(idSeleccionado))
            {
                // Si no hay ID, es un nuevo registro
                query = "INSERT INTO Proveedores (id_proveedor, nombre_proveedor, telefono_proveedor) VALUES (@id, @nombre, @telefono)";
            }

            else
            {
                // Si hay ID, es una edición (Solo cambiamos nombre y teléfono del que ya existe)
                query = "UPDATE Proveedores SET nombre_proveedor = @nombre, telefono_proveedor = @telefono WHERE id_proveedor = @id";
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        // vinculacion de los parámetros 
                        comando.Parameters.AddWithValue("@id", textBox3.Text); // ID
                        comando.Parameters.AddWithValue("@nombre", textBox1.Text); // Nombre
                        comando.Parameters.AddWithValue("@telefono", textBox2.Text); // Teléfono

                        comando.ExecuteNonQuery();
                    }
                }

            string msj = string.IsNullOrEmpty(idSeleccionado) ? "agregado" : "actualizado";
            MessageBox.Show($"Proveedor {msj} con éxito.");

            this.DialogResult = DialogResult.OK;
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
