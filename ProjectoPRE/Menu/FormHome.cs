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
            // Limpiamos la gráfica antes de cualquier cosa
            chartStock.Series["Series1"].Points.Clear();

            if (rolUsuario == "Admin")
            {
                panelNavegacion.BackColor = Color.LightCoral;
                lblTituloDashboard.Text = "Dashboard de Administrador";

                chartStock.Visible = true;
                CargarGraficaStock(); // Gráfica de Stock bajo para Admin
            }
            else
            {
                panelNavegacion.BackColor = Color.LightGreen;
                lblTituloDashboard.Text = "Dashboard de Empleado";

                chartStock.Visible = true; // la mostramos para el empleado
                CargarGraficaVentasEmpleado(); // datos de ventas
            }
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

                    // Cambiamos el color de la gráfica para el empleado (un verde suave)
                    chartStock.Series["Series1"].Color = Color.MediumSeaGreen;

                    while (dr.Read())
                    {
                        chartStock.Series["Series1"].Points.AddXY(dr["nombre_producto"].ToString(), dr["TotalVendidos"]);
                    }
                }
            }
            catch (Exception ex)
            {
                // Si no hay ventas aún, mostrar un mensaje amigable o dejar vacío
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
