namespace ProjectoPRE
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
            this.nave = new System.Windows.Forms.Label();
            this.lblTituloDashboard = new System.Windows.Forms.Label();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelNavegacion.Controls.Add(this.btnProductos);
            this.panelNavegacion.Controls.Add(this.btnProveedores);
            this.panelNavegacion.Controls.Add(this.btnVentas);
            this.panelNavegacion.Controls.Add(this.btnInventario);
            this.panelNavegacion.Controls.Add(this.nave);
            this.panelNavegacion.Location = new System.Drawing.Point(-25, -13);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(231, 776);
            this.panelNavegacion.TabIndex = 0;
            // 
            // nave
            // 
            this.nave.AutoSize = true;
            this.nave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nave.Location = new System.Drawing.Point(48, 50);
            this.nave.Name = "nave";
            this.nave.Size = new System.Drawing.Size(159, 29);
            this.nave.TabIndex = 0;
            this.nave.Text = "Navegacion";
            this.nave.Click += new System.EventHandler(this.nave_Click);
            // 
            // lblTituloDashboard
            // 
            this.lblTituloDashboard.AutoSize = true;
            this.lblTituloDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTituloDashboard.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDashboard.Location = new System.Drawing.Point(473, 27);
            this.lblTituloDashboard.Name = "lblTituloDashboard";
            this.lblTituloDashboard.Size = new System.Drawing.Size(354, 39);
            this.lblTituloDashboard.TabIndex = 1;
            this.lblTituloDashboard.Text = "Dashboard Libreria San Juan";
            this.lblTituloDashboard.UseCompatibleTextRendering = true;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInventario.Location = new System.Drawing.Point(42, 185);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(154, 56);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(42, 266);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(154, 47);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProveedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(42, 347);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(154, 47);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProductos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(42, 425);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(154, 47);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 760);
            this.Controls.Add(this.lblTituloDashboard);
            this.Controls.Add(this.panelNavegacion);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.panelNavegacion.ResumeLayout(false);
            this.panelNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Label nave;
        private System.Windows.Forms.Label lblTituloDashboard;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnVentas;
    }
}