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
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label1.Location = new System.Drawing.Point(556, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Escoja su perfil";
			// 
			// btnAdmin
			// 
			this.btnAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdmin.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdmin.ForeColor = System.Drawing.Color.Black;
			this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdmin.Location = new System.Drawing.Point(334, 225);
			this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(292, 247);
			this.btnAdmin.TabIndex = 1;
			this.btnAdmin.Text = "Administración";
			this.btnAdmin.UseVisualStyleBackColor = false;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
			// 
			// btnEmpleado
			// 
			this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEmpleado.Location = new System.Drawing.Point(743, 225);
			this.btnEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEmpleado.Name = "btnEmpleado";
			this.btnEmpleado.Size = new System.Drawing.Size(292, 247);
			this.btnEmpleado.TabIndex = 2;
			this.btnEmpleado.Text = "Empleados";
			this.btnEmpleado.UseVisualStyleBackColor = false;
			this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click_1);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1382, 653);
			this.Controls.Add(this.btnEmpleado);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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