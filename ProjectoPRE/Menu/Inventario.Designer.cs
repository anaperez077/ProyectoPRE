namespace ProjectoPRE
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Producto = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(473, 76);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescripcion.Location = new System.Drawing.Point(473, 116);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(151, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStock.Location = new System.Drawing.Point(473, 155);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(151, 22);
            this.txtStock.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Location = new System.Drawing.Point(373, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(216, 33);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "+Agregar al inventario\r\n\r\n\r\n";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPrecio.Location = new System.Drawing.Point(473, 194);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(151, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(311, 79);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(137, 16);
            this.Producto.TabIndex = 6;
            this.Producto.Text = "Nombre del producto:";
            this.Producto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(366, 122);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(82, 16);
            this.Descripcion.TabIndex = 7;
            this.Descripcion.Text = "Descripcion:";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(329, 161);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(119, 16);
            this.Stock.TabIndex = 8;
            this.Stock.Text = "Cantidad en Stock:";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(353, 200);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(95, 16);
            this.precio.TabIndex = 9;
            this.precio.Text = "Precio unitario:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.Location = new System.Drawing.Point(429, 42);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(133, 16);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "Gestion de Inventario";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnAgregar;
            this.ClientSize = new System.Drawing.Size(1070, 726);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label Titulo;
    }
}