using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

//Falta añadir editar y eliminar datos
//Se puede agregar una parte de mostrar datos y filtrarlos desde la BD

namespace ProjectoPRE
{
    public partial class Inventario : Form
    {
        // Ruta directa de la base de datos a usar
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
            if (rolUsuario == "Empleado") {
    btnEliminar.Enabled = false;
    btnEditar.Enabled = false;
}
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

        //esta seccion del boton agregar no es la funcional, sin embargo si la borro deja de funcionar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN CON AYUDA DE IA
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
                            // 1. Insertar en  tabla productos
                            string sqlProd = "INSERT INTO Productos (nombre_producto, descripcion_producto) VALUES (@nom, @desc); SELECT last_insert_rowid();";
                            SQLiteCommand cmd1 = new SQLiteCommand(sqlProd, conexion);
                            cmd1.Parameters.AddWithValue("@nom", txtNombre.Text);
                            cmd1.Parameters.AddWithValue("@desc", txtDescripcion.Text);

                            // Obtenemos el ID que se acaba de crear
                            long idRecienCreado = (long)cmd1.ExecuteScalar();

                            // 2. Insertar en tabla Inventario usando ese ID
                            string sqlInv = "INSERT INTO Inventario (id_producto, stock_producto, precio_producto) VALUES (@id, @stock, @precio);";
                            SQLiteCommand cmd2 = new SQLiteCommand(sqlInv, conexion);
                            cmd2.Parameters.AddWithValue("@id", idRecienCreado);
                            cmd2.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                            cmd2.Parameters.AddWithValue("@precio", Convert.ToDouble(txtPrecio.Text));
                            cmd2.ExecuteNonQuery();

                            transaccion.Commit();
                            MessageBox.Show("Producto e Inventario guardados correctamente.");

                            CargarInventarioCompleto(); // Actualizar la tabla de los datos
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
            // Verificamos que no hayamos tocado el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Pasamos los datos de la fila seleccionada a los TextBox
                // Nota: El índice [1] es Nombre, [2] es Stock, etc., según tu SELECT
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio Unitario"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripción"].Value.ToString();

                // Guardamos el ID en un lugar invisible para saber cuál editar/eliminar
                txtNombre.Tag = fila.Cells["ID Producto"].Value.ToString();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //CODIGO CON AYUDA DE IA
        //Seccion de agregar codigo funcional
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

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (txtNombre.Tag == null) { MessageBox.Show("Selecciona un producto"); return; }

                DialogResult resp = MessageBox.Show("¿Seguro que quieres eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                        {
                            conexion.Open();
                            // Al eliminar de Productos, por la relación de la BD, se debería borrar del inventario
                            string sql = "DELETE FROM Productos WHERE id_producto=@id";
                            SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
                            cmd.Parameters.AddWithValue("@id", txtNombre.Tag);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Producto eliminado");
                            CargarInventarioCompleto();
                            LimpiarControles();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error al eliminar: " + ex.Message); }
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                if (txtNombre.Tag == null) { MessageBox.Show("Selecciona un producto de la tabla"); return; }

                try
                {
                    using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                    {
                        conexion.Open();
                        using (var trans = conexion.BeginTransaction())
                        {
                            // Actualizar tabla Productos
                            string sql1 = "UPDATE Productos SET nombre_producto=@nom, descripcion_producto=@desc WHERE id_producto=@id";
                            SQLiteCommand cmd1 = new SQLiteCommand(sql1, conexion);
                            cmd1.Parameters.AddWithValue("@nom", txtNombre.Text);
                            cmd1.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                            cmd1.Parameters.AddWithValue("@id", txtNombre.Tag);
                            cmd1.ExecuteNonQuery();

                            // Actualizar tabla Inventario
                            string sql2 = "UPDATE Inventario SET stock_producto=@stock, precio_producto=@pre WHERE id_producto=@id";
                            SQLiteCommand cmd2 = new SQLiteCommand(sql2, conexion);
                            cmd2.Parameters.AddWithValue("@stock", txtStock.Text);
                            cmd2.Parameters.AddWithValue("@pre", txtPrecio.Text);
                            cmd2.Parameters.AddWithValue("@id", txtNombre.Tag);
                            cmd2.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Producto actualizado correctamente");
                            CargarInventarioCompleto();
                            LimpiarControles();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error al editar: " + ex.Message); }
            }
        }
    }

}

