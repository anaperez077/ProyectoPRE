namespace ProjectoPRE
{
    partial class Ventas
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
			this.lblProducto = new System.Windows.Forms.Label();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numCantidad = new System.Windows.Forms.NumericUpDown();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dgvCarrito = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnFinalizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Titulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProducto
			// 
			this.lblProducto.AutoSize = true;
			this.lblProducto.BackColor = System.Drawing.Color.Transparent;
			this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProducto.Location = new System.Drawing.Point(712, 104);
			this.lblProducto.Name = "lblProducto";
			this.lblProducto.Size = new System.Drawing.Size(223, 25);
			this.lblProducto.TabIndex = 0;
			this.lblProducto.Text = "Seleccionar producto:";
			// 
			// cmbProducto
			// 
			this.cmbProducto.BackColor = System.Drawing.Color.White;
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Location = new System.Drawing.Point(466, 144);
			this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(695, 24);
			this.cmbProducto.TabIndex = 1;
			this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(463, 223);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cantidad:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// numCantidad
			// 
			this.numCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.numCantidad.Location = new System.Drawing.Point(566, 221);
			this.numCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numCantidad.Name = "numCantidad";
			this.numCantidad.Size = new System.Drawing.Size(120, 22);
			this.numCantidad.TabIndex = 3;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAgregar.Location = new System.Drawing.Point(1016, 212);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(145, 39);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Añadir";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// dgvCarrito
			// 
			this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCarrito.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombre,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
			this.dgvCarrito.Location = new System.Drawing.Point(466, 272);
			this.dgvCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvCarrito.Name = "dgvCarrito";
			this.dgvCarrito.RowHeadersWidth = 51;
			this.dgvCarrito.RowTemplate.Height = 24;
			this.dgvCarrito.Size = new System.Drawing.Size(696, 123);
			this.dgvCarrito.TabIndex = 5;
			this.dgvCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellContentClick);
			// 
			// colID
			// 
			this.colID.HeaderText = "ID";
			this.colID.MinimumWidth = 6;
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			// 
			// colNombre
			// 
			this.colNombre.HeaderText = "Producto";
			this.colNombre.MinimumWidth = 6;
			this.colNombre.Name = "colNombre";
			this.colNombre.ReadOnly = true;
			// 
			// colCantidad
			// 
			this.colCantidad.HeaderText = "Cant.";
			this.colCantidad.MinimumWidth = 6;
			this.colCantidad.Name = "colCantidad";
			this.colCantidad.ReadOnly = true;
			// 
			// colPrecio
			// 
			this.colPrecio.HeaderText = "Precio Unit.";
			this.colPrecio.MinimumWidth = 6;
			this.colPrecio.Name = "colPrecio";
			this.colPrecio.ReadOnly = true;
			// 
			// colSubtotal
			// 
			this.colSubtotal.HeaderText = "Subtotal";
			this.colSubtotal.MinimumWidth = 6;
			this.colSubtotal.Name = "colSubtotal";
			this.colSubtotal.ReadOnly = true;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.Black;
			this.lblTotal.Location = new System.Drawing.Point(957, 412);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(179, 20);
			this.lblTotal.TabIndex = 6;
			this.lblTotal.Text = "Total a Pagar: $0.00";
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnFinalizar.Location = new System.Drawing.Point(708, 464);
			this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(193, 54);
			this.btnFinalizar.TabIndex = 7;
			this.btnFinalizar.Text = "Registrar";
			this.btnFinalizar.UseVisualStyleBackColor = false;
			this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(563, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 8;
			// 
			// Titulo
			// 
			this.Titulo.AutoSize = true;
			this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Titulo.Location = new System.Drawing.Point(745, 61);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(143, 22);
			this.Titulo.TabIndex = 11;
			this.Titulo.Text = "Registrar Venta";
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.Titulo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dgvCarrito);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.numCantidad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbProducto);
			this.Controls.Add(this.lblProducto);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Ventas_Load);
			((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
    }
}