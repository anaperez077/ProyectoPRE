namespace ProjectoPRE
{
    partial class FormLogin
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.Bienvenido = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Silver;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(202, 252);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(265, 195);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administracion";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Silver;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Location = new System.Drawing.Point(585, 252);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(250, 195);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            // 
            // Bienvenido
            // 
            this.Bienvenido.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Bienvenido.AutoSize = true;
            this.Bienvenido.BackColor = System.Drawing.Color.DarkSalmon;
            this.Bienvenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bienvenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bienvenido.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.Location = new System.Drawing.Point(411, 78);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(265, 53);
            this.Bienvenido.TabIndex = 2;
            this.Bienvenido.Text = "Bienvenido";
            this.Bienvenido.Click += new System.EventHandler(this.Bienvenido_Click);
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(385, 181);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(312, 45);
            this.texto1.TabIndex = 3;
            this.texto1.Text = "Escoja su perfil";
            this.texto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.texto1.Click += new System.EventHandler(this.texto1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1090, 691);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.Bienvenido);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnAdmin);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.Label texto1;
    }
}