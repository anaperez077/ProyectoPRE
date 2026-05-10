namespace ProjectoPRE
{
    partial class Proveedores
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
			this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.tbox_buscar = new System.Windows.Forms.TextBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Titulo = new System.Windows.Forms.Label();
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
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clNombre,
            this.clTelefono});
			this.dataGridView1.Location = new System.Drawing.Point(513, 202);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(666, 154);
			this.dataGridView1.TabIndex = 1;
			// 
			// clID
			// 
			this.clID.DataPropertyName = "id_proveedor";
			this.clID.HeaderText = "ID";
			this.clID.MinimumWidth = 6;
			this.clID.Name = "clID";
			this.clID.ReadOnly = true;
			// 
			// clNombre
			// 
			this.clNombre.DataPropertyName = "nombre_proveedor";
			this.clNombre.HeaderText = "Nombre";
			this.clNombre.MinimumWidth = 6;
			this.clNombre.Name = "clNombre";
			this.clNombre.ReadOnly = true;
			// 
			// clTelefono
			// 
			this.clTelefono.DataPropertyName = "telefono_proveedor";
			this.clTelefono.HeaderText = "Telefono";
			this.clTelefono.MinimumWidth = 6;
			this.clTelefono.Name = "clTelefono";
			this.clTelefono.ReadOnly = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAgregar.Location = new System.Drawing.Point(466, 402);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(232, 56);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// tbox_buscar
			// 
			this.tbox_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbox_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbox_buscar.Location = new System.Drawing.Point(736, 140);
			this.tbox_buscar.Name = "tbox_buscar";
			this.tbox_buscar.Size = new System.Drawing.Size(289, 24);
			this.tbox_buscar.TabIndex = 3;
			this.tbox_buscar.TextChanged += new System.EventHandler(this.tbox_buscar_TextChanged);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnEditar.Location = new System.Drawing.Point(731, 402);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(232, 56);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnEliminar.Location = new System.Drawing.Point(997, 402);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(232, 56);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(664, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Buscar:";
			// 
			// Titulo
			// 
			this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Titulo.AutoSize = true;
			this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Titulo.Location = new System.Drawing.Point(714, 78);
			this.Titulo.Name = "Titulo";
			this.Titulo.Size = new System.Drawing.Size(246, 22);
			this.Titulo.TabIndex = 11;
			this.Titulo.Text = "Información de Proveedores";
			// 
			// Proveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.Titulo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.tbox_buscar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Proveedores";
			this.Text = "Proveedores";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Proveedores_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbox_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTelefono;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Titulo;
    }
}