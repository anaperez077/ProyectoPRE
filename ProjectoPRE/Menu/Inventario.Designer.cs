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
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.Buscar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(341, 172);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(983, 229);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(639, 441);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNombre.Multiline = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(193, 24);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(996, 444);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(198, 24);
			this.txtDescripcion.TabIndex = 2;
			// 
			// txtStock
			// 
			this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStock.Location = new System.Drawing.Point(639, 480);
			this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(134, 24);
			this.txtStock.TabIndex = 3;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAgregar.Location = new System.Drawing.Point(710, 547);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(220, 34);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "+ Agregar al inventario\r\n\r\n\r\n";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(996, 483);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(134, 24);
			this.txtPrecio.TabIndex = 5;
			this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
			// 
			// Producto
			// 
			this.Producto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Producto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Producto.Location = new System.Drawing.Point(434, 441);
			this.Producto.Name = "Producto";
			this.Producto.Size = new System.Drawing.Size(207, 24);
			this.Producto.TabIndex = 6;
			this.Producto.Text = "Nombre del producto:";
			this.Producto.Click += new System.EventHandler(this.label1_Click);
			// 
			// Descripcion
			// 
			this.Descripcion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Descripcion.Location = new System.Drawing.Point(864, 444);
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Size = new System.Drawing.Size(126, 29);
			this.Descripcion.TabIndex = 7;
			this.Descripcion.Text = "Descripcion:";
			// 
			// Stock
			// 
			this.Stock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Stock.Location = new System.Drawing.Point(434, 483);
			this.Stock.Name = "Stock";
			this.Stock.Size = new System.Drawing.Size(190, 24);
			this.Stock.TabIndex = 8;
			this.Stock.Text = "Cantidad en Stock:";
			// 
			// precio
			// 
			this.precio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.precio.Location = new System.Drawing.Point(838, 486);
			this.precio.Name = "precio";
			this.precio.Size = new System.Drawing.Size(152, 28);
			this.precio.TabIndex = 9;
			this.precio.Text = "Precio unitario:";
			// 
			// Titulo
			// 
			this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Titulo.AutoSize = true;
			this.Titulo.BackColor = System.Drawing.Color.Wheat;
			this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Titulo.Location = new System.Drawing.Point(724, 38);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(190, 22);
			this.Titulo.TabIndex = 10;
			this.Titulo.Text = "Gestion de Inventario";
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnEditar.Location = new System.Drawing.Point(457, 547);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(206, 34);
			this.btnEditar.TabIndex = 11;
			this.btnEditar.Text = "Editar Seleccionado";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnEliminar.Location = new System.Drawing.Point(980, 547);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(214, 34);
			this.btnEliminar.TabIndex = 12;
			this.btnEliminar.Text = "Eliminar Seleccionado";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.txtBuscar.Location = new System.Drawing.Point(621, 115);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(393, 22);
			this.txtBuscar.TabIndex = 13;
			this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
			// 
			// Buscar
			// 
			this.Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Buscar.AutoSize = true;
			this.Buscar.BackColor = System.Drawing.Color.Transparent;
			this.Buscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buscar.Location = new System.Drawing.Point(695, 85);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(247, 22);
			this.Buscar.TabIndex = 14;
			this.Buscar.Text = "Buscar en el inventario: ";
			// 
			// Inventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.Buscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
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
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Inventario";
			this.Text = "Inventario";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label Buscar;
    }
}