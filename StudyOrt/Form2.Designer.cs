
namespace StudyOrt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.TxtBoxApellido = new System.Windows.Forms.TextBox();
            this.TxtBoxDni = new System.Windows.Forms.TextBox();
            this.TxtBoxContaseña = new System.Windows.Forms.TextBox();
            this.TxtBoxRepContraseña = new System.Windows.Forms.TextBox();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.chkBoxMostrar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(45, 115);
            this.TxtBoxNombre.Multiline = true;
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(254, 34);
            this.TxtBoxNombre.TabIndex = 1;
            // 
            // TxtBoxApellido
            // 
            this.TxtBoxApellido.Location = new System.Drawing.Point(318, 115);
            this.TxtBoxApellido.Multiline = true;
            this.TxtBoxApellido.Name = "TxtBoxApellido";
            this.TxtBoxApellido.Size = new System.Drawing.Size(254, 34);
            this.TxtBoxApellido.TabIndex = 2;
            // 
            // TxtBoxDni
            // 
            this.TxtBoxDni.Location = new System.Drawing.Point(45, 170);
            this.TxtBoxDni.Multiline = true;
            this.TxtBoxDni.Name = "TxtBoxDni";
            this.TxtBoxDni.Size = new System.Drawing.Size(527, 34);
            this.TxtBoxDni.TabIndex = 3;
            // 
            // TxtBoxContaseña
            // 
            this.TxtBoxContaseña.Location = new System.Drawing.Point(45, 226);
            this.TxtBoxContaseña.Multiline = true;
            this.TxtBoxContaseña.Name = "TxtBoxContaseña";
            this.TxtBoxContaseña.PasswordChar = '•';
            this.TxtBoxContaseña.Size = new System.Drawing.Size(527, 34);
            this.TxtBoxContaseña.TabIndex = 4;
            // 
            // TxtBoxRepContraseña
            // 
            this.TxtBoxRepContraseña.Location = new System.Drawing.Point(45, 281);
            this.TxtBoxRepContraseña.Multiline = true;
            this.TxtBoxRepContraseña.Name = "TxtBoxRepContraseña";
            this.TxtBoxRepContraseña.PasswordChar = '•';
            this.TxtBoxRepContraseña.Size = new System.Drawing.Size(527, 34);
            this.TxtBoxRepContraseña.TabIndex = 5;
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarse.BackgroundImage")));
            this.BtnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarse.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarse.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarse.Location = new System.Drawing.Point(52, 355);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(233, 41);
            this.BtnRegistrarse.TabIndex = 6;
            this.BtnRegistrarse.UseVisualStyleBackColor = false;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // chkBoxMostrar
            // 
            this.chkBoxMostrar.AutoSize = true;
            this.chkBoxMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(139)))));
            this.chkBoxMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkBoxMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxMostrar.FlatAppearance.BorderSize = 0;
            this.chkBoxMostrar.Location = new System.Drawing.Point(59, 324);
            this.chkBoxMostrar.Name = "chkBoxMostrar";
            this.chkBoxMostrar.Size = new System.Drawing.Size(29, 17);
            this.chkBoxMostrar.TabIndex = 7;
            this.chkBoxMostrar.Text = " ";
            this.chkBoxMostrar.UseVisualStyleBackColor = false;
            this.chkBoxMostrar.CheckedChanged += new System.EventHandler(this.chkBoxMostrar_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::StudyOrt.Properties.Resources.Group_43;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Location = new System.Drawing.Point(52, 401);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(158, 37);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyOrt.Properties.Resources.registretstasstddfytawerfoiuuy___5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBoxMostrar);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.TxtBoxRepContraseña);
            this.Controls.Add(this.TxtBoxContaseña);
            this.Controls.Add(this.TxtBoxDni);
            this.Controls.Add(this.TxtBoxApellido);
            this.Controls.Add(this.TxtBoxNombre);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.TextBox TxtBoxApellido;
        private System.Windows.Forms.TextBox TxtBoxDni;
        private System.Windows.Forms.TextBox TxtBoxContaseña;
        private System.Windows.Forms.TextBox TxtBoxRepContraseña;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.CheckBox chkBoxMostrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolver;
    }
}