using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;


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
            this.rolUsuario = rol;

            //Adaptar el form al diseño del contenedor 
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarInventarioCompleto();

            //Bucle if para filtrar acciones segun el perfil
            if (rolUsuario == "Empleado")
            {
                //Ocultamos los botones de acción para empleado
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                //Ocultamos los cuadros de texto y sus etiquetas (Labels)
                txtNombre.Visible = false;
                txtDescripcion.Visible = false;
                txtStock.Visible = false;
                txtPrecio.Visible = false;
                Producto.Visible = false; 
                precio.Visible = false;
                Descripcion.Visible = false;
                Stock.Visible = false; 
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

        //Limpiar botones del inventario
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
            // Verificamos que no hayamos tocado el encabezado con un if
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

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
            //Vacio
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //CODIGO DE CONSULTAS A LA BD CON AYUDA DE IA
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //Verificamos que los campos no estén vacíos
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
                            //Insertar en la tabla Productos
                            string sqlProducto = "INSERT INTO Productos (nombre_producto, descripcion_producto) VALUES (@nom, @desc); SELECT last_insert_rowid();";
                            SQLiteCommand cmdP = new SQLiteCommand(sqlProducto, conexion);
                            cmdP.Parameters.AddWithValue("@nom", txtNombre.Text);
                            cmdP.Parameters.AddWithValue("@desc", txtDescripcion.Text);

                            //Ejecutamos y obtenemos el ID que la base de datos le asignó al producto
                            long nuevoId = (long)cmdP.ExecuteScalar();

                            //Insertamos en la tabla Inventario usando ese ID
                            string sqlInventario = "INSERT INTO Inventario (id_producto, stock_producto, precio_producto) VALUES (@id, @stock, @precio)";
                            SQLiteCommand cmdI = new SQLiteCommand(sqlInventario, conexion);
                            cmdI.Parameters.AddWithValue("@id", nuevoId);
                            cmdI.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                            cmdI.Parameters.AddWithValue("@precio", double.Parse(txtPrecio.Text));
                            cmdI.ExecuteNonQuery();

                            //Confirmamos los cambios
                            transaccion.Commit();

                            MessageBox.Show("Producto guardado correctamente en el Inventario", "Éxito");

                            //Limpiamos los cuadros de texto y refrescamos la tabla visual
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

        //Proceso para eliminar un dato del inventario
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

        //Proceso para editar un producto de inventario
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
                            MessageBox.Show("Producto actualizado correctamente");//Confirmamos
                            CargarInventarioCompleto();
                            LimpiarControles();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error al editar: " + ex.Message); }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Llamamos a una función que filtre la tabla mientras escribes
            FiltrarDatos(txtBuscar.Text);
        }

        //Seccion para la bsuqueda de productos de la seccion cliente
        private void FiltrarDatos(string textoABuscar) // El parámetro se llama textoABuscar
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Consulta SQL
                    string query = @"SELECT 
                                P.id_producto AS [ID Producto], 
                                P.nombre_producto AS [Nombre], 
                                IFNULL(I.stock_producto, 0) AS [Stock], 
                                IFNULL(I.precio_producto, 0.0) AS [Precio Unitario],
                                P.descripcion_producto AS [Descripción]
                             FROM Productos P
                             LEFT JOIN Inventario I ON P.id_producto = I.id_producto
                             WHERE P.nombre_producto LIKE @filtro 
                             OR CAST(P.id_producto AS TEXT) LIKE @filtro";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conexion);

                    da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + textoABuscar + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }
    }
}

