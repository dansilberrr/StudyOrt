
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtBxDni = new System.Windows.Forms.TextBox();
            this.TxtBxContra = new System.Windows.Forms.TextBox();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.chkBoxmostrar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBxDni
            // 
            this.TxtBxDni.BackColor = System.Drawing.Color.White;
            this.TxtBxDni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDni.Location = new System.Drawing.Point(290, 219);
            this.TxtBxDni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxDni.Multiline = true;
            this.TxtBxDni.Name = "TxtBxDni";
            this.TxtBxDni.Size = new System.Drawing.Size(353, 35);
            this.TxtBxDni.TabIndex = 1;
            this.TxtBxDni.TextChanged += new System.EventHandler(this.TxtBxDni_TextChanged);
            // 
            // TxtBxContra
            // 
            this.TxtBxContra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxContra.Location = new System.Drawing.Point(291, 285);
            this.TxtBxContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBxContra.Multiline = true;
            this.TxtBxContra.Name = "TxtBxContra";
            this.TxtBxContra.PasswordChar = '•';
            this.TxtBxContra.Size = new System.Drawing.Size(353, 35);
            this.TxtBxContra.TabIndex = 2;
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCrearCuenta.BackgroundImage")));
            this.BtnCrearCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.BtnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCuenta.Location = new System.Drawing.Point(329, 432);
            this.BtnCrearCuenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(274, 58);
            this.BtnCrearCuenta.TabIndex = 4;
            this.BtnCrearCuenta.UseVisualStyleBackColor = false;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // chkBoxmostrar
            // 
            this.chkBoxmostrar.AutoSize = true;
            this.chkBoxmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(139)))));
            this.chkBoxmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkBoxmostrar.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxmostrar.FlatAppearance.BorderSize = 0;
            this.chkBoxmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBoxmostrar.ForeColor = System.Drawing.Color.Black;
            this.chkBoxmostrar.Location = new System.Drawing.Point(295, 335);
            this.chkBoxmostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBoxmostrar.Name = "chkBoxmostrar";
            this.chkBoxmostrar.Size = new System.Drawing.Size(12, 11);
            this.chkBoxmostrar.TabIndex = 6;
            this.chkBoxmostrar.UseVisualStyleBackColor = false;
            this.chkBoxmostrar.CheckedChanged += new System.EventHandler(this.chkBoxmostrar_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(291, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 51);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkBoxmostrar);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.TxtBxContra);
            this.Controls.Add(this.TxtBxDni);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "sd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBxDni;
        private System.Windows.Forms.TextBox TxtBxContra;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.CheckBox chkBoxmostrar;
        private System.Windows.Forms.Button button1;
    }
}

