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
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.btnEmpleado = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Escoga su perfil";
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(124, 109);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(202, 176);
			this.btnAdmin.TabIndex = 1;
			this.btnAdmin.Text = "Administración";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
			// 
			// btnEmpleado
			// 
			this.btnEmpleado.Location = new System.Drawing.Point(428, 109);
			this.btnEmpleado.Name = "btnEmpleado";
			this.btnEmpleado.Size = new System.Drawing.Size(202, 176);
			this.btnEmpleado.TabIndex = 2;
			this.btnEmpleado.Text = "Empleados";
			this.btnEmpleado.UseVisualStyleBackColor = true;
			this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click_1);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEmpleado);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEmpleado;
    }
}