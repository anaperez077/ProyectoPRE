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

namespace ProjectoPRE.Menu
{
    public partial class Historial : Form
    {
        // Para saber si es Admin o Empleado
        private string rolUsuario;
        public Historial(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        public void CargarHistorial()
        {
            using (SQLiteConnection conexion = new SQLiteConnection("Data Source=LibreriaSJ.db;Version=3;"))
            {
                try
                {
                    conexion.Open();
                    string query = @"
                SELECT 
                    V.id_venta AS 'ID Venta', 
                    P.nombre_producto AS 'Producto', 
                    DV.cantidad AS 'Cantidad', 
                    DV.precio AS 'Precio Unit.',
                    (DV.cantidad * DV.precio) AS 'Sub Total'
                FROM Ventas V
                INNER JOIN Detalle_Venta DV ON V.id_venta = DV.id_venta
                INNER JOIN Productos P ON DV.id_producto = P.id_producto
                ORDER BY V.id_venta DESC";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //Evitamos duplicados
                    dgvHistorial.DataSource = null; // Limpia datos viejos
                    dgvHistorial.Columns.Clear();
                    dgvHistorial.DataSource = dt;// Cargamos las columnas nuevas a la BD

                    // Ajusta el ancho para que se vea profesional
                    dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

    }
}
