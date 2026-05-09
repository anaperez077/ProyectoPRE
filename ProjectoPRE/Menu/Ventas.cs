using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoPRE
{
    public partial class Ventas : Form
    {
    private string rolUsuario; // Para saber si es Admin o Empleado
        public Ventas(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                // Usamos la conexión que ya definieron en el archivo Conexion.cs
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    // Traemos solo productos que tengan stock
                    string query = "SELECT id_producto, nombre_producto FROM Productos";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProducto.DataSource = dt;
                    cmbProducto.DisplayMember = "nombre_producto"; // Lo que ve el usuario
                    cmbProducto.ValueMember = "id_producto";      // El ID oculto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        //Seccion para agregar nueva venta
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones con if
            if (cmbProducto.SelectedIndex == -1 || numCantidad.Value <= 0)
            {
                MessageBox.Show("Por favor, seleccione un producto y una cantidad válida.");
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            string nombreProducto = cmbProducto.Text;
            int cantidadSolicitada = Convert.ToInt32(numCantidad.Value);

            // Consultar stock y precio en la base de datos
            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                string query = "SELECT stock_producto, precio_producto FROM Inventario WHERE id_producto = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", idProducto);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int stockActual = reader.GetInt32(0);
                        double precioUnitario = reader.GetDouble(1);

                        //Verificar si hay stock suficiente
                        if (cantidadSolicitada > stockActual)
                        {
                            MessageBox.Show($"No hay suficiente stock. Disponible: {stockActual}");
                        }
                        else
                        {
                            //Calcular subtotal y agregar al DataGridView
                            double subtotal = cantidadSolicitada * precioUnitario;
                            dgvCarrito.Rows.Add(idProducto, nombreProducto, cantidadSolicitada, precioUnitario, subtotal);

                            //Actualizar el total general
                            ActualizarTotal();
                        }
                    }
                }
            }
        }
        private void ActualizarTotal()
        {
            double total = 0;
            foreach (DataGridViewRow fila in dgvCarrito.Rows)
            {
                if (fila.Cells["colSubtotal"].Value != null)
                    total += Convert.ToDouble(fila.Cells["colSubtotal"].Value);
            }
            lblTotal.Text = "Total a Pagar: $" + total.ToString("N2");
        }

        //Proceso para finalizar ventas
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                conexion.Open();
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        //Insertar a la tabla "Venta"
                        string sqlVenta = "INSERT INTO Ventas (fecha) VALUES (datetime('now')); SELECT last_insert_rowid();";
                        SQLiteCommand cmdVenta = new SQLiteCommand(sqlVenta, conexion, transaccion);
                        long idVenta = (long)cmdVenta.ExecuteScalar();

                        //Recorrer el DataGridView/grafica para insertar detalles y descontar stock
                        foreach (DataGridViewRow fila in dgvCarrito.Rows)
                        {
                            if (fila.Cells[0].Value == null) continue;

                            int idProd = Convert.ToInt32(fila.Cells[0].Value);
                            int cant = Convert.ToInt32(fila.Cells[2].Value);
                            double precio = Convert.ToDouble(fila.Cells[3].Value);

                            // Insertar en tabla Detalle_Venta
                            string sqlDetalle = "INSERT INTO Detalle_Venta (id_venta, id_producto, cantidad, precio) VALUES (@idV, @idP, @cant, @pre)";
                            SQLiteCommand cmdDetalle = new SQLiteCommand(sqlDetalle, conexion, transaccion);
                            cmdDetalle.Parameters.AddWithValue("@idV", idVenta);
                            cmdDetalle.Parameters.AddWithValue("@idP", idProd);
                            cmdDetalle.Parameters.AddWithValue("@cant", cant);
                            cmdDetalle.Parameters.AddWithValue("@pre", precio);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                        MessageBox.Show("¡Venta realizada con éxito! El stock ha sido actualizado.");
                        // Limpiar todo para la siguiente venta
                        dgvCarrito.Rows.Clear();
                        ActualizarTotal();
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("Error al procesar la venta: " + ex.Message);
                    }
                }
            }
        }
    }
}
