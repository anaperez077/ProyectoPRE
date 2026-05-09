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

namespace ProjectoPRE
{
    public partial class Proveedores : Form
    {
        private string rolUsuario; // Para saber si es Admin o Empleado

        public Proveedores(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;

            //Adaptar el form al diseño del contenedor 
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }
        public void CargarDatos()
        {
            string cadenaConexion = "Data Source=LibreriaSJ.db;Version=3";

            using (var conexion = new SQLiteConnection(cadenaConexion))
            {
               
                conexion.Open();
                string query = "SELECT id_proveedor, nombre_proveedor, telefono_proveedor FROM Proveedores";

                using (var comando = new SQLiteCommand(query, conexion))
                {
                    using (var adaptador = new SQLiteDataAdapter(comando)) 
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dataGridView1.DataSource = tabla;
                    }
                }
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();

            // Si el usuario es "Cliente" (o como se llame tu rol), ocultamos botones
            if (rolUsuario == "Cliente")
            {
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                // El tbox_buscar y el dataGridView1 se quedan visibles para que puedan "Buscar y Ver"
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProveedores segundoformProv = new AgregarProveedores(rolUsuario);
            segundoformProv.ShowDialog();
            CargarDatos();  
        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, seleccione al proveedor que desea editar.");
                return;
            }

            AgregarProveedores frm = new AgregarProveedores(rolUsuario);

            // Pasamos los datos usando las variables públicas (Igual que en Inventario)
            frm.idSeleccionado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.NombreProveedor = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.TelefonoProveedor = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, seleccione una fila en la tabla primero.");
                return;

            }

            //obteniendo ID de fila seleccionada

            var valorId = dataGridView1.CurrentRow.Cells[0].Value;  

            if ( valorId == null )
            {
                MessageBox.Show("No se pudo obtener el ID de la fila seleccionada.");
                return;
            }

            string idABorrar = valorId.ToString();

            //confirmacion de seguridad
            DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de eliminar al proveedor con ID {idABorrar}", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(confirmacion == DialogResult.Yes )
            {
                string cadenaConexion = "Data Source=LibreriaSJ.db;Version=3;";
                string query = "DELETE FROM Proveedores WHERE id_proveedor = @id";

                try
                {
                    using (var conexion = new System.Data.SQLite.SQLiteConnection(cadenaConexion)) 
                    {
                        conexion.Open();
                        using (var comando = new System.Data.SQLite.SQLiteCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@id", idABorrar);
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("¡Eliminado con éxito!");
                    CargarDatos();
                }
                catch (System.Data.SQLite.SQLiteException ex)
                {
                    if (ex.ResultCode == System.Data.SQLite.SQLiteErrorCode.Constraint)
                    {
                        MessageBox.Show("No puedes eliminar a este proveedore porque tiene productos asignados en el iventario");
                    }
                    else
                    {
                        MessageBox.Show("Error de base de datos: " + ex.Message);
                    }
                }

            }
        }

        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source=LibreriaSJ.db;Version=3;";
            // Buscamos por nombre
            string query = "SELECT id_proveedor, nombre_proveedor, telefono_proveedor FROM Proveedores WHERE nombre_proveedor LIKE @buscar";

            using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@buscar", "%" + tbox_buscar.Text + "%");
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter da = new SQLiteDataAdapter(comando);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex) { /* Silencioso para no molestar mientras escriben */ }
            }
        }
    }
 }
 