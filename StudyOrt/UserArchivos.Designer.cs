
namespace StudyOrt
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lbltxtAla = new System.Windows.Forms.Label();
            this.lblAcl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnDescArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "nombre\r\n";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(16, 32);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Tema";
            // 
            // lbltxtAla
            // 
            this.lbltxtAla.AutoSize = true;
            this.lbltxtAla.Location = new System.Drawing.Point(16, 48);
            this.lbltxtAla.Name = "lbltxtAla";
            this.lbltxtAla.Size = new System.Drawing.Size(68, 13);
            this.lbltxtAla.TabIndex = 2;
            this.lbltxtAla.Text = "Aclaraciones";
            // 
            // lblAcl
            // 
            this.lblAcl.AutoSize = true;
            this.lblAcl.Location = new System.Drawing.Point(16, 64);
            this.lblAcl.Name = "lblAcl";
            this.lblAcl.Size = new System.Drawing.Size(148, 13);
            this.lblAcl.TabIndex = 3;
            this.lblAcl.Text = "Aclaraciones(lo que escribe x)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 80);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // btnDescArchivo
            // 
            this.btnDescArchivo.Location = new System.Drawing.Point(143, 11);
            this.btnDescArchivo.Name = "btnDescArchivo";
            this.btnDescArchivo.Size = new System.Drawing.Size(111, 23);
            this.btnDescArchivo.TabIndex = 5;
            this.btnDescArchivo.Text = "Descargar Archivo";
            this.btnDescArchivo.UseVisualStyleBackColor = true;
            this.btnDescArchivo.Click += new System.EventHandler(this.btnDescArchivo_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDescArchivo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAcl);
            this.Controls.Add(this.lbltxtAla);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblNombre);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(262, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lbltxtAla;
        private System.Windows.Forms.Label lblAcl;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnDescArchivo;
    }
}
