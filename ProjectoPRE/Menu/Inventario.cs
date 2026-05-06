using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProjectoPRE
{
    public partial class Inventario : Form
    {
        // Ruta directa. Asegúrate de que el archivo .db esté en la carpeta bin/Debug
        private string cadenaConexion = "Data Source=LibreriaSJ.db;Version=3;";
        private string rolUsuario; // Para saber si es Admin o Empleado

        public Inventario(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol; // Guardamos lo que viene del formHome
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarInventarioCompleto();
        }

        public void CargarInventarioCompleto()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Usamos LEFT JOIN para que si el producto no tiene inventario, 
                    // aparezca en la lista con valores en 0 o vacíos.
                    string query = @"SELECT 
                                        P.id_producto AS [ID Producto], 
                                        P.nombre_producto AS [Nombre], 
                                        IFNULL(I.stock_producto, 0) AS [Stock], 
                                        IFNULL(I.precio_producto, 0.0) AS [Precio Unitario],
                                        P.descripcion_producto AS [Descripción]
                                     FROM Productos P
                                     LEFT JOIN Inventario I ON P.id_producto = I.id_producto";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN BÁSICA
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor llena el nombre y el precio.");
                return;
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Iniciamos una transacción para asegurar que se guarde en AMBAS tablas o en ninguna
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insertar en Productos
                            string sqlProd = "INSERT INTO Productos (nombre_producto, descripcion_producto) VALUES (@nom, @desc); SELECT last_insert_rowid();";
                            SQLiteCommand cmd1 = new SQLiteCommand(sqlProd, conexion);
                            cmd1.Parameters.AddWithValue("@nom", txtNombre.Text);
                            cmd1.Parameters.AddWithValue("@desc", txtDescripcion.Text);

                            // Obtenemos el ID que se acaba de crear
                            long idRecienCreado = (long)cmd1.ExecuteScalar();

                            // 2. Insertar en Inventario usando ese ID
                            string sqlInv = "INSERT INTO Inventario (id_producto, stock_producto, precio_producto) VALUES (@id, @stock, @precio);";
                            SQLiteCommand cmd2 = new SQLiteCommand(sqlInv, conexion);
                            cmd2.Parameters.AddWithValue("@id", idRecienCreado);
                            cmd2.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                            cmd2.Parameters.AddWithValue("@precio", Convert.ToDouble(txtPrecio.Text));
                            cmd2.ExecuteNonQuery();

                            transaccion.Commit();
                            MessageBox.Show("Producto e Inventario guardados correctamente.");

                            CargarInventarioCompleto(); // Refrescar el grid
                            LimpiarControles();
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback(); // Si algo falla, deshace los cambios
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Por ahora vacío
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //CODIGO CON AYUDA DE IA
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // 1. Verificamos que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Stock y Precio).", "Advertencia");
                return;
            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Usamos una transacción: si falla el segundo paso, no se guarda el primero
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // PASO A: Insertar en la tabla Productos
                            string sqlProducto = "INSERT INTO Productos (nombre_producto, descripcion_producto) VALUES (@nom, @desc); SELECT last_insert_rowid();";
                            SQLiteCommand cmdP = new SQLiteCommand(sqlProducto, conexion);
                            cmdP.Parameters.AddWithValue("@nom", txtNombre.Text);
                            cmdP.Parameters.AddWithValue("@desc", txtDescripcion.Text);

                            // Ejecutamos y obtenemos el ID que la base de datos le asignó al producto
                            long nuevoId = (long)cmdP.ExecuteScalar();

                            // PASO B: Insertar en la tabla Inventario usando ese ID
                            string sqlInventario = "INSERT INTO Inventario (id_producto, stock_producto, precio_producto) VALUES (@id, @stock, @precio)";
                            SQLiteCommand cmdI = new SQLiteCommand(sqlInventario, conexion);
                            cmdI.Parameters.AddWithValue("@id", nuevoId);
                            cmdI.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                            cmdI.Parameters.AddWithValue("@precio", double.Parse(txtPrecio.Text));
                            cmdI.ExecuteNonQuery();

                            // Si llegamos aquí sin errores, confirmamos los cambios
                            transaccion.Commit();

                            MessageBox.Show("Producto guardado correctamente en el Inventario", "Éxito");

                            // Limpiamos los cuadros de texto y refrescamos la tabla visual
                            LimpiarControles();
                            CargarInventarioCompleto();
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback(); // Si algo falló, deshace todo para no dejar datos corruptos
                            MessageBox.Show("Error al guardar en la base de datos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }


        }
    }

}

