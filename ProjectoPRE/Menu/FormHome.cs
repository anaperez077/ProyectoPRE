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

// Codigos de las consultas, tablas, filtros a la BD realizados con ayuda de IA

namespace ProjectoPRE.Menu
{
    public partial class FormHome : Form
    {
        private string rolUsuario;
        public FormHome(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            // Aseguramos que los controles iniciales estén DENTRO del panel al empezar
            if (!panelContenedor.Controls.Contains(chartStock))
            {
                panelContenedor.Controls.Add(chartStock);
                panelContenedor.Controls.Add(lblTituloDashboard);
            }

            ConfigurarDashboard();
        }

        // Creamos este método para mostrar home segun perfil
        private void ConfigurarDashboard()
        {
            chartStock.Series["Series1"].Points.Clear();

            if (rolUsuario == "Admin")
            {
                panelNavegacion.BackColor = Color.LightCoral;
                lblTituloDashboard.Text = "Dashboard de Administrador";
                CargarGraficaStock();
            }
            else
            {
                panelNavegacion.BackColor = Color.LightGreen;
                lblTituloDashboard.Text = "Dashboard de Empleado";
                CargarGraficaVentasEmpleado();
            }
            chartStock.Visible = true;
        }

        private void CargarGraficaVentasEmpleado()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection("Data Source=LibreriaSJ.db;Version=3;"))
                {
                    conexion.Open();
                    // Consulta: Sumamos la cantidad vendida por cada nombre de producto
                    string query = @"SELECT nombre_producto, SUM(cantidad) as TotalVendidos 
                             FROM Detalle_Venta 
                             GROUP BY nombre_producto 
                             ORDER BY TotalVendidos DESC LIMIT 5";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    SQLiteDataReader dr = cmd.ExecuteReader();

                    chartStock.Series["Series1"].Points.Clear();
                    chartStock.Titles.Clear();
                    chartStock.Titles.Add("Top 5 Productos Más Vendidos");

                    chartStock.Series["Series1"].Color = Color.MediumSeaGreen;

                    while (dr.Read())
                    {
                        chartStock.Series["Series1"].Points.AddXY(dr["nombre_producto"].ToString(), dr["TotalVendidos"]);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si no hay ventas aún, mostrar un mensaje
                chartStock.Titles.Add("Sin datos de ventas aún");
            }
        }
        private void CargarGraficaStock()
        {
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection("Data Source=LibreriaSJ.db;Version=3;"))
                {
                    conexion.Open();
                    // Traemos los 5 productos con menos stock
                    string query = @"SELECT P.nombre_producto, I.stock_producto 
                             FROM Productos P 
                             INNER JOIN Inventario I ON P.id_producto = I.id_producto 
                             ORDER BY I.stock_producto ASC LIMIT 5";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    SQLiteDataReader dr = cmd.ExecuteReader();

                    // Limpiamos la gráfica por si ya tiene datos
                    chartStock.Series["Series1"].Points.Clear();
                    chartStock.Titles.Clear();
                    chartStock.Titles.Add("Productos con Poco Stock");

                    while (dr.Read())
                    {
                        // Agregamos Nombre al eje X y Stock al eje Y
                        chartStock.Series["Series1"].Points.AddXY(dr["nombre_producto"].ToString(), dr["stock_producto"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfica: " + ex.Message);
            }
        }

        //Al hacer click en los botones abrir sus forms correspondientes
        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Inventario(rolUsuario));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

            AbrirFormularioHijo(new Ventas(rolUsuario));
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Historial(rolUsuario));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // 1. Buscamos y eliminamos CUALQUIER formulario que esté en el panel
            // Usamos un ciclo for inverso para evitar errores de colección
            for (int i = panelContenedor.Controls.Count - 1; i >= 0; i--)
            {
                if (panelContenedor.Controls[i] is Form)
                {
                    panelContenedor.Controls.RemoveAt(i);
                }
            }

            // 2. Limpiamos títulos viejos para que no se amontonen con los nuevos
            chartStock.Titles.Clear();

            // 3. Hacemos visibles los controles base
            chartStock.Visible = true;
            lblTituloDashboard.Visible = true;

            // Forzamos que se pongan al frente por si quedaron atrás
            chartStock.BringToFront();
            lblTituloDashboard.BringToFront();

            // 4. Refrescamos datos
            ConfigurarDashboard();
        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            // 1. Ocultamos la gráfica y el título en lugar de borrarlos
            chartStock.Visible = false;
            lblTituloDashboard.Visible = false;

            // 2. Si ya hay OTRO formulario abierto (ej. abres Ventas estando en Inventario), ese sí lo quitamos
            foreach (Control control in panelContenedor.Controls)
            {
                if (control is Form)
                {
                    panelContenedor.Controls.Remove(control);
                    break;
                }
            }

            // 3. Configuramos y mostramos el nuevo formulario
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //Colocar aqui el form de Proveedores
        }

    }

}
