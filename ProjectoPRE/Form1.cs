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
    public partial class Form1 : Form
    {
        public void CargarVentas()
        {
            string conn = "Data Source=LibreriaSJ.db;Version=3;";

            using (var conexion = new SQLiteConnection(conn))
            {
                conexion.Open();

                string query = @"SELECT v.id_venta, v.fecha,
                         IFNULL(SUM(d.cantidad * d.precio), 0) AS total
                         FROM Ventas v
                         LEFT JOIN Detalle_Venta d ON v.id_venta = d.id_venta
                         GROUP BY v.id_venta";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
