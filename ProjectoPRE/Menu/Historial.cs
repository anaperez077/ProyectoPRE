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
        private string rolUsuario; // Para saber si es Admin o Empleado
        public Historial(string rol)
        {
            InitializeComponent();
            this.rolUsuario = rol;

            // AGREGA ESTAS DOS LÍNEAS:
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }
        public void CargarHistorial()
        {
            using (SQLiteConnection conexion = new SQLiteConnection("Data Source=LibreriaSJ.db;Version=3;"))
            {
                conexion.Open();
                string query = @"
            SELECT 
                V.id_venta AS 'Ticket #', 
                P.nombre_producto AS 'Producto', 
                DV.cantidad AS 'Cant.', 
                DV.precio_unitario AS 'Precio Unit.',
                (DV.cantidad * DV.precio_unitario) AS 'Subtotal'
            FROM Ventas V
            INNER JOIN Detalle_Ventas DV ON V.id_venta = DV.id_venta
            INNER JOIN Productos P ON DV.id_producto = P.id_producto
            ORDER BY V.id_venta DESC"; // Las más recientes primero

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHistorial.DataSource = dt;
            }
        }
    }
}
