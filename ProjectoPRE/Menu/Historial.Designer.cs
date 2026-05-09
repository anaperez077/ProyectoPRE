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
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHistorial
			// 
			this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorial.Location = new System.Drawing.Point(476, 181);
			this.dgvHistorial.Name = "dgvHistorial";
			this.dgvHistorial.RowHeadersWidth = 51;
			this.dgvHistorial.RowTemplate.Height = 24;
			this.dgvHistorial.Size = new System.Drawing.Size(814, 437);
			this.dgvHistorial.TabIndex = 0;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(1142, 70);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(148, 75);
			this.btnActualizar.TabIndex = 1;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(740, 70);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(740, 123);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(264, 22);
			this.dateTimePicker2.TabIndex = 3;
			// 
			// Desde
			// 
			this.Desde.AutoSize = true;
			this.Desde.Location = new System.Drawing.Point(645, 70);
			this.Desde.Name = "Desde";
			this.Desde.Size = new System.Drawing.Size(54, 16);
			this.Desde.TabIndex = 4;
			this.Desde.Text = "Desde :";
			// 
			// Hasta
			// 
			this.Hasta.AutoSize = true;
			this.Hasta.Location = new System.Drawing.Point(650, 123);
			this.Hasta.Name = "Hasta";
			this.Hasta.Size = new System.Drawing.Size(49, 16);
			this.Hasta.TabIndex = 5;
			this.Hasta.Text = "Hasta :";
			// 
			// Titulo
			// 
			this.Titulo.AutoSize = true;
			this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Titulo.Location = new System.Drawing.Point(783, 25);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(173, 22);
			this.Titulo.TabIndex = 11;
			this.Titulo.Text = "Historial de Ventas";
			this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
			// 
			// Historial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.Titulo);
			this.Controls.Add(this.Hasta);
			this.Controls.Add(this.Desde);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.dgvHistorial);
			this.Name = "Historial";
			this.Text = "Historial";
			this.Load += new System.EventHandler(this.Historial_Load);
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
    }
}