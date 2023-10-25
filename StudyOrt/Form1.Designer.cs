
namespace StudyOrt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBxDni = new System.Windows.Forms.TextBox();
            this.TxtBxContra = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.ImgLogo1 = new System.Windows.Forms.PictureBox();
            this.chkBoxmostrar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBxDni
            // 
            this.TxtBxDni.Location = new System.Drawing.Point(334, 136);
            this.TxtBxDni.Name = "TxtBxDni";
            this.TxtBxDni.Size = new System.Drawing.Size(122, 20);
            this.TxtBxDni.TabIndex = 1;
            // 
            // TxtBxContra
            // 
            this.TxtBxContra.Location = new System.Drawing.Point(334, 183);
            this.TxtBxContra.Name = "TxtBxContra";
            this.TxtBxContra.PasswordChar = '•';
            this.TxtBxContra.Size = new System.Drawing.Size(122, 20);
            this.TxtBxContra.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(334, 275);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(126, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "INICIAR SESION";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(334, 346);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(126, 23);
            this.BtnCrearCuenta.TabIndex = 4;
            this.BtnCrearCuenta.Text = "CREAR CUENTA";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // ImgLogo1
            // 
            this.ImgLogo1.Location = new System.Drawing.Point(346, 61);
            this.ImgLogo1.Name = "ImgLogo1";
            this.ImgLogo1.Size = new System.Drawing.Size(100, 50);
            this.ImgLogo1.TabIndex = 5;
            this.ImgLogo1.TabStop = false;
            // 
            // chkBoxmostrar
            // 
            this.chkBoxmostrar.AutoSize = true;
            this.chkBoxmostrar.Location = new System.Drawing.Point(334, 229);
            this.chkBoxmostrar.Name = "chkBoxmostrar";
            this.chkBoxmostrar.Size = new System.Drawing.Size(118, 17);
            this.chkBoxmostrar.TabIndex = 6;
            this.chkBoxmostrar.Text = "Mostrar Contraseña";
            this.chkBoxmostrar.UseVisualStyleBackColor = true;
            this.chkBoxmostrar.CheckedChanged += new System.EventHandler(this.chkBoxmostrar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxmostrar);
            this.Controls.Add(this.ImgLogo1);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBxContra);
            this.Controls.Add(this.TxtBxDni);
            this.Name = "Form1";
            this.Text = "    ";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBxDni;
        private System.Windows.Forms.TextBox TxtBxContra;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.PictureBox ImgLogo1;
        private System.Windows.Forms.CheckBox chkBoxmostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

