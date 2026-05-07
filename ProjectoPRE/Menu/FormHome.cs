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

//Codigos de las consultas, tablas, filtros a la BD realizados con ayuda de IA

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

        //Ak hacer click en los botones abrir sus forms correspondientes
        private void btnInventario_Click(object sender, EventArgs e)
        {
            
            MostrarVentana(new Inventario(rolUsuario));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            
            MostrarVentana(new Ventas(rolUsuario));
        }

        private void lblTituloDashboard_Click(object sender, EventArgs e)
        {

        }

        private void chartStock_Click(object sender, EventArgs e)
        {

        }

        private void MostrarVentana(Form ventanaHija)
        {
            // Si ya hay algo adentro (como la gráfica o otro formulario), lo borramos
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.Clear();
            }

            //Configuramos la nueva ventana para que se porte como un panel
            ventanaHija.TopLevel = false;          // No es una ventana independiente
            ventanaHija.FormBorderStyle = FormBorderStyle.None; // Sin bordes ni botones de cerrar
            ventanaHija.Dock = DockStyle.Fill;     // Que se estire al tamaño del panel

            // 3. La metemos al panel y la mostramos
            this.panelContenedor.Controls.Add(ventanaHija);
            ventanaHija.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            // 1. Quitamos los formularios (Ventas/Inventario) pero NO borramos los controles del Home
            // Buscamos si hay algún Form abierto y lo cerramos
            foreach (Control item in panelContenedor.Controls)
            {
                if (item is Form)
                {
                    panelContenedor.Controls.Remove(item);
                }
            }

            // 2. Aseguramos que la gráfica y el título vuelvan a ser visibles y estén ahí
            chartStock.Visible = true;
            lblTituloDashboard.Visible = true;

            // 3. Refrescamos los datos
            ConfigurarDashboard();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //Colocar aqui el form de Proveedores
        }
    }

}
