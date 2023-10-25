
namespace StudyOrt
{
    partial class subir_archivo
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
            this.lblTema = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblAclara = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnSubirArchivo = new System.Windows.Forms.Button();
            this.OpenFileSubirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(29, 37);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(34, 13);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(30, 111);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(28, 188);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // lblAclara
            // 
            this.lblAclara.AutoSize = true;
            this.lblAclara.Location = new System.Drawing.Point(28, 278);
            this.lblAclara.Name = "lblAclara";
            this.lblAclara.Size = new System.Drawing.Size(68, 13);
            this.lblAclara.TabIndex = 4;
            this.lblAclara.Text = "Aclaraciones";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arte",
            "Biologia",
            "Educacion Judia",
            "Educacion Tecnologica",
            "Etica",
            "Geografia",
            "Historia",
            "Lengua",
            "Matematica",
            "Educacion Fisica",
            "Ingles",
            "Hebreo"});
            this.comboBox1.Location = new System.Drawing.Point(21, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.comboBox2.Location = new System.Drawing.Point(21, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // BtnSubir
            // 
            this.BtnSubir.Location = new System.Drawing.Point(442, 336);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(108, 44);
            this.BtnSubir.TabIndex = 8;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.UseVisualStyleBackColor = true;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // BtnSubirArchivo
            // 
            this.BtnSubirArchivo.Location = new System.Drawing.Point(356, 197);
            this.BtnSubirArchivo.Name = "BtnSubirArchivo";
            this.BtnSubirArchivo.Size = new System.Drawing.Size(192, 41);
            this.BtnSubirArchivo.TabIndex = 10;
            this.BtnSubirArchivo.Text = "Elegir Archivo";
            this.BtnSubirArchivo.UseVisualStyleBackColor = true;
            this.BtnSubirArchivo.Click += new System.EventHandler(this.BtnSubirArchivo_Click);
            // 
            // OpenFileSubirArchivo
            // 
            this.OpenFileSubirArchivo.FileName = "openFileDialog1";
            this.OpenFileSubirArchivo.Filter = "Word Documents|*.docx|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt|PDF d" +
    "ocument (*.pdf)|*.pdf|All Files|*.*";
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.Location = new System.Drawing.Point(353, 241);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(0, 13);
            this.lblRutaArchivo.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(598, 336);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(108, 44);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // subir_archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.BtnSubirArchivo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnSubir);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAclara);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTema);
            this.Name = "subir_archivo";
            this.Text = "subir_archivo";
            this.Load += new System.EventHandler(this.subir_archivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblAclara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnSubirArchivo;
        private System.Windows.Forms.OpenFileDialog OpenFileSubirArchivo;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.Button btnVolver;
    }
}