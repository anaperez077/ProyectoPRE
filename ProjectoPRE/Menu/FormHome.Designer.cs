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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.chartStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblTituloDashboard = new System.Windows.Forms.Label();
			this.panelNavegacion = new System.Windows.Forms.Panel();
			this.PanelN = new System.Windows.Forms.Label();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnVentas = new System.Windows.Forms.Button();
			this.btnInventario = new System.Windows.Forms.Button();
			this.btnProveedores = new System.Windows.Forms.Button();
			this.panelContenedor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartStock)).BeginInit();
			this.panelNavegacion.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelContenedor
			// 
			this.panelContenedor.BackColor = System.Drawing.Color.Wheat;
			this.panelContenedor.Controls.Add(this.chartStock);
			this.panelContenedor.Controls.Add(this.lblTituloDashboard);
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 0);
			this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(1382, 653);
			this.panelContenedor.TabIndex = 2;
			// 
			// chartStock
			// 
			this.chartStock.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			chartArea2.Name = "ChartArea1";
			this.chartStock.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartStock.Legends.Add(legend2);
			this.chartStock.Location = new System.Drawing.Point(404, 101);
			this.chartStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chartStock.Name = "chartStock";
			this.chartStock.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartStock.Series.Add(series2);
			this.chartStock.Size = new System.Drawing.Size(871, 521);
			this.chartStock.TabIndex = 3;
			this.chartStock.Text = "chart1";
			// 
			// lblTituloDashboard
			// 
			this.lblTituloDashboard.AutoSize = true;
			this.lblTituloDashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloDashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTituloDashboard.Location = new System.Drawing.Point(667, 53);
			this.lblTituloDashboard.Name = "lblTituloDashboard";
			this.lblTituloDashboard.Size = new System.Drawing.Size(314, 29);
			this.lblTituloDashboard.TabIndex = 2;
			this.lblTituloDashboard.Text = "DashBoard de Administrador";
			// 
			// panelNavegacion
			// 
			this.panelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panelNavegacion.Controls.Add(this.PanelN);
			this.panelNavegacion.Controls.Add(this.btnInicio);
			this.panelNavegacion.Controls.Add(this.btnInventario);
			this.panelNavegacion.Controls.Add(this.btnVentas);
			this.panelNavegacion.Controls.Add(this.btnProveedores);
			this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelNavegacion.Location = new System.Drawing.Point(0, 0);
			this.panelNavegacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelNavegacion.Name = "panelNavegacion";
			this.panelNavegacion.Size = new System.Drawing.Size(228, 653);
			this.panelNavegacion.TabIndex = 4;
			// 
			// PanelN
			// 
			this.PanelN.AutoSize = true;
			this.PanelN.BackColor = System.Drawing.Color.Transparent;
			this.PanelN.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PanelN.Location = new System.Drawing.Point(26, 71);
			this.PanelN.Name = "PanelN";
			this.PanelN.Size = new System.Drawing.Size(173, 22);
			this.PanelN.TabIndex = 3;
			this.PanelN.Text = "Panel de navegacion";
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.Location = new System.Drawing.Point(23, 126);
			this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(185, 60);
			this.btnInicio.TabIndex = 4;
			this.btnInicio.Text = "Home";
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnVentas
			// 
			this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVentas.Location = new System.Drawing.Point(23, 214);
			this.btnVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(185, 60);
			this.btnVentas.TabIndex = 1;
			this.btnVentas.Text = "Ventas";
			this.btnVentas.UseVisualStyleBackColor = false;
			this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
			// 
			// btnInventario
			// 
			this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInventario.Location = new System.Drawing.Point(23, 302);
			this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnInventario.Name = "btnInventario";
			this.btnInventario.Size = new System.Drawing.Size(185, 60);
			this.btnInventario.TabIndex = 0;
			this.btnInventario.Text = "Inventario";
			this.btnInventario.UseVisualStyleBackColor = false;
			this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
			// 
			// btnProveedores
			// 
			this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProveedores.Location = new System.Drawing.Point(23, 391);
			this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnProveedores.Name = "btnProveedores";
			this.btnProveedores.Size = new System.Drawing.Size(185, 60);
			this.btnProveedores.TabIndex = 2;
			this.btnProveedores.Text = "Proveedores";
			this.btnProveedores.UseVisualStyleBackColor = false;
			this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
			// 
			// FormHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.panelNavegacion);
			this.Controls.Add(this.panelContenedor);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormHome";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.FormHome_Load);
			this.panelContenedor.ResumeLayout(false);
			this.panelContenedor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartStock)).EndInit();
			this.panelNavegacion.ResumeLayout(false);
			this.panelNavegacion.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStock;
        private System.Windows.Forms.Label lblTituloDashboard;
        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Label PanelN;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInicio;
    }
}