namespace ProjectoPRE.Menu
{
    partial class Historial
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
			this.dgvHistorial = new System.Windows.Forms.DataGridView();
			this.colIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHistorial
			// 
			this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHistorial.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVenta,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
			this.dgvHistorial.Location = new System.Drawing.Point(408, 152);
			this.dgvHistorial.Name = "dgvHistorial";
			this.dgvHistorial.RowHeadersWidth = 51;
			this.dgvHistorial.RowTemplate.Height = 24;
			this.dgvHistorial.Size = new System.Drawing.Size(858, 404);
			this.dgvHistorial.TabIndex = 0;
			// 
			// colIdVenta
			// 
			this.colIdVenta.HeaderText = "ID Venta";
			this.colIdVenta.MinimumWidth = 6;
			this.colIdVenta.Name = "colIdVenta";
			this.colIdVenta.ReadOnly = true;
			// 
			// colProducto
			// 
			this.colProducto.HeaderText = "Producto";
			this.colProducto.MinimumWidth = 6;
			this.colProducto.Name = "colProducto";
			this.colProducto.ReadOnly = true;
			// 
			// colCantidad
			// 
			this.colCantidad.HeaderText = "Cantidad";
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
			this.colSubtotal.HeaderText = "SubTotal";
			this.colSubtotal.MinimumWidth = 6;
			this.colSubtotal.Name = "colSubtotal";
			this.colSubtotal.ReadOnly = true;
			// 
			// Titulo
			// 
			this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Titulo.AutoSize = true;
			this.Titulo.BackColor = System.Drawing.Color.Wheat;
			this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Titulo.Location = new System.Drawing.Point(734, 70);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(182, 24);
			this.Titulo.TabIndex = 11;
			this.Titulo.Text = "Historial de Ventas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(322, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 12;
			// 
			// Historial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Titulo);
			this.Controls.Add(this.dgvHistorial);
			this.Name = "Historial";
			this.Text = "Historial";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Historial_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}