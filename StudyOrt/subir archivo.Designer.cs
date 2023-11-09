
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnSubirArchivo = new System.Windows.Forms.Button();
            this.OpenFileSubirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.btnCasita = new System.Windows.Forms.Button();
            this.BtnCositoSubir = new System.Windows.Forms.Button();
            this.BtnLogitoPerfil = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 27);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.comboBox1.Location = new System.Drawing.Point(138, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.comboBox2.Location = new System.Drawing.Point(138, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 254);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 85);
            this.textBox2.TabIndex = 9;
            // 
            // BtnSubirArchivo
            // 
            this.BtnSubirArchivo.BackgroundImage = global::StudyOrt.Properties.Resources.POSTA;
            this.BtnSubirArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSubirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubirArchivo.FlatAppearance.BorderSize = 0;
            this.BtnSubirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirArchivo.Location = new System.Drawing.Point(140, 345);
            this.BtnSubirArchivo.Name = "BtnSubirArchivo";
            this.BtnSubirArchivo.Size = new System.Drawing.Size(251, 22);
            this.BtnSubirArchivo.TabIndex = 10;
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
            // btnCasita
            // 
            this.btnCasita.BackColor = System.Drawing.Color.Transparent;
            this.btnCasita.BackgroundImage = global::StudyOrt.Properties.Resources.home_1;
            this.btnCasita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCasita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCasita.Location = new System.Drawing.Point(1, 99);
            this.btnCasita.Name = "btnCasita";
            this.btnCasita.Size = new System.Drawing.Size(43, 43);
            this.btnCasita.TabIndex = 12;
            this.btnCasita.UseVisualStyleBackColor = false;
            this.btnCasita.Click += new System.EventHandler(this.btnCasita_Click);
            // 
            // BtnCositoSubir
            // 
            this.BtnCositoSubir.BackColor = System.Drawing.Color.Transparent;
            this.BtnCositoSubir.BackgroundImage = global::StudyOrt.Properties.Resources.share;
            this.BtnCositoSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCositoSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCositoSubir.Location = new System.Drawing.Point(1, 179);
            this.BtnCositoSubir.Name = "BtnCositoSubir";
            this.BtnCositoSubir.Size = new System.Drawing.Size(43, 43);
            this.BtnCositoSubir.TabIndex = 13;
            this.BtnCositoSubir.UseVisualStyleBackColor = false;
            // 
            // BtnLogitoPerfil
            // 
            this.BtnLogitoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogitoPerfil.BackgroundImage = global::StudyOrt.Properties.Resources.person;
            this.BtnLogitoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogitoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogitoPerfil.Location = new System.Drawing.Point(1, 259);
            this.BtnLogitoPerfil.Name = "BtnLogitoPerfil";
            this.BtnLogitoPerfil.Size = new System.Drawing.Size(43, 43);
            this.BtnLogitoPerfil.TabIndex = 14;
            this.BtnLogitoPerfil.UseVisualStyleBackColor = false;
            this.BtnLogitoPerfil.Click += new System.EventHandler(this.BtnLogitoPerfil_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::StudyOrt.Properties.Resources.system_uicons_exit_left__1_;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(2, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 43);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::StudyOrt.Properties.Resources.botonsubir1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(139, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // subir_archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyOrt.Properties.Resources.SUBIR_TACHADO__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnLogitoPerfil);
            this.Controls.Add(this.BtnCositoSubir);
            this.Controls.Add(this.btnCasita);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.BtnSubirArchivo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "subir_archivo";
            this.Text = "subir_archivo";
            this.Load += new System.EventHandler(this.subir_archivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnSubirArchivo;
        private System.Windows.Forms.OpenFileDialog OpenFileSubirArchivo;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.Button btnCasita;
        private System.Windows.Forms.Button BtnCositoSubir;
        private System.Windows.Forms.Button BtnLogitoPerfil;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}