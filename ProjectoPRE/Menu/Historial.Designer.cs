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
			this.btnActualizar = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.Desde = new System.Windows.Forms.Label();
			this.Hasta = new System.Windows.Forms.Label();
			this.Titulo = new System.Windows.Forms.Label();
			this.colIdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.Buscar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHistorial
			// 
			this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHistorial.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVenta,
            this.colFecha,
            this.colTotal});
			this.dgvHistorial.Location = new System.Drawing.Point(476, 211);
			this.dgvHistorial.Name = "dgvHistorial";
			this.dgvHistorial.RowHeadersWidth = 51;
			this.dgvHistorial.RowTemplate.Height = 24;
			this.dgvHistorial.Size = new System.Drawing.Size(814, 418);
			this.dgvHistorial.TabIndex = 0;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnActualizar.Location = new System.Drawing.Point(1050, 115);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(148, 75);
			this.btnActualizar.TabIndex = 1;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(740, 123);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(740, 165);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(264, 22);
			this.dateTimePicker2.TabIndex = 3;
			// 
			// Desde
			// 
			this.Desde.AutoSize = true;
			this.Desde.BackColor = System.Drawing.Color.Transparent;
			this.Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Desde.Location = new System.Drawing.Point(662, 123);
			this.Desde.Name = "Desde";
			this.Desde.Size = new System.Drawing.Size(57, 16);
			this.Desde.TabIndex = 4;
			this.Desde.Text = "Desde:";
			// 
			// Hasta
			// 
			this.Hasta.AutoSize = true;
			this.Hasta.BackColor = System.Drawing.Color.Transparent;
			this.Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hasta.Location = new System.Drawing.Point(662, 165);
			this.Hasta.Name = "Hasta";
			this.Hasta.Size = new System.Drawing.Size(52, 16);
			this.Hasta.TabIndex = 5;
			this.Hasta.Text = "Hasta:";
			// 
			// Titulo
			// 
			this.Titulo.AutoSize = true;
			this.Titulo.BackColor = System.Drawing.Color.Wheat;
			this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Titulo.Location = new System.Drawing.Point(783, 25);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(173, 22);
			this.Titulo.TabIndex = 11;
			this.Titulo.Text = "Historial de Ventas";
			// 
			// colIdVenta
			// 
			this.colIdVenta.HeaderText = "ID Venta";
			this.colIdVenta.MinimumWidth = 6;
			this.colIdVenta.Name = "colIdVenta";
			this.colIdVenta.ReadOnly = true;
			// 
			// colFecha
			// 
			this.colFecha.HeaderText = "Fecha";
			this.colFecha.MinimumWidth = 6;
			this.colFecha.Name = "colFecha";
			this.colFecha.ReadOnly = true;
			// 
			// colTotal
			// 
			this.colTotal.HeaderText = "Total Venta";
			this.colTotal.MinimumWidth = 6;
			this.colTotal.Name = "colTotal";
			this.colTotal.ReadOnly = true;
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
			// Buscar
			// 
			this.Buscar.AutoSize = true;
			this.Buscar.BackColor = System.Drawing.Color.Transparent;
			this.Buscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buscar.Location = new System.Drawing.Point(779, 78);
			this.Buscar.Name = "Buscar";
			this.Buscar.Size = new System.Drawing.Size(179, 22);
			this.Buscar.TabIndex = 15;
			this.Buscar.Text = "Buscar por fecha:";
			// 
			// Historial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.Buscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Titulo);
			this.Controls.Add(this.Hasta);
			this.Controls.Add(this.Desde);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.dgvHistorial);
			this.Name = "Historial";
			this.Text = "Historial";
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Buscar;
    }
}