namespace ProjectoPRE.Menu
{
    partial class FormHome
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
			this.panelNavegacion = new System.Windows.Forms.Panel();
			this.lblTituloDashboard = new System.Windows.Forms.Label();
			this.btnInventario = new System.Windows.Forms.Button();
			this.btnVentas = new System.Windows.Forms.Button();
			this.btnProveedores = new System.Windows.Forms.Button();
			this.panelNavegacion.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelNavegacion
			// 
			this.panelNavegacion.Controls.Add(this.btnProveedores);
			this.panelNavegacion.Controls.Add(this.btnVentas);
			this.panelNavegacion.Controls.Add(this.btnInventario);
			this.panelNavegacion.Location = new System.Drawing.Point(9, 44);
			this.panelNavegacion.Name = "panelNavegacion";
			this.panelNavegacion.Size = new System.Drawing.Size(213, 395);
			this.panelNavegacion.TabIndex = 0;
			// 
			// lblTituloDashboard
			// 
			this.lblTituloDashboard.AutoSize = true;
			this.lblTituloDashboard.Location = new System.Drawing.Point(403, 63);
			this.lblTituloDashboard.Name = "lblTituloDashboard";
			this.lblTituloDashboard.Size = new System.Drawing.Size(248, 16);
			this.lblTituloDashboard.TabIndex = 0;
			this.lblTituloDashboard.Text = "DashBoard de Administrador/Empleado";
			// 
			// btnInventario
			// 
			this.btnInventario.Location = new System.Drawing.Point(27, 198);
			this.btnInventario.Name = "btnInventario";
			this.btnInventario.Size = new System.Drawing.Size(158, 53);
			this.btnInventario.TabIndex = 0;
			this.btnInventario.Text = "Inventario";
			this.btnInventario.UseVisualStyleBackColor = true;
			this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
			// 
			// btnVentas
			// 
			this.btnVentas.Location = new System.Drawing.Point(27, 119);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(158, 53);
			this.btnVentas.TabIndex = 1;
			this.btnVentas.Text = "Ventas";
			this.btnVentas.UseVisualStyleBackColor = true;
			this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
			// 
			// btnProveedores
			// 
			this.btnProveedores.Location = new System.Drawing.Point(27, 284);
			this.btnProveedores.Name = "btnProveedores";
			this.btnProveedores.Size = new System.Drawing.Size(158, 53);
			this.btnProveedores.TabIndex = 2;
			this.btnProveedores.Text = "Proveedores";
			this.btnProveedores.UseVisualStyleBackColor = true;
			// 
			// FormHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblTituloDashboard);
			this.Controls.Add(this.panelNavegacion);
			this.Name = "FormHome";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.FormHome_Load);
			this.panelNavegacion.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Label lblTituloDashboard;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnVentas;
    }
}