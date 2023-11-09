
namespace StudyOrt
{
    partial class Perfil
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
            this.nameSurname = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.casita = new System.Windows.Forms.Button();
            this.subirito = new System.Windows.Forms.Button();
            this.perfilito = new System.Windows.Forms.Button();
            this.cerrarsesionito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameSurname
            // 
            this.nameSurname.AutoSize = true;
            this.nameSurname.BackColor = System.Drawing.Color.Transparent;
            this.nameSurname.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSurname.Location = new System.Drawing.Point(383, 21);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(34, 29);
            this.nameSurname.TabIndex = 0;
            this.nameSurname.Text = "...";
            this.nameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.BackColor = System.Drawing.Color.Transparent;
            this.dni.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(384, 50);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(25, 24);
            this.dni.TabIndex = 1;
            this.dni.Text = "...";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(701, 344);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // casita
            // 
            this.casita.BackColor = System.Drawing.Color.Transparent;
            this.casita.BackgroundImage = global::StudyOrt.Properties.Resources.home_1;
            this.casita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.casita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.casita.Location = new System.Drawing.Point(1, 99);
            this.casita.Name = "casita";
            this.casita.Size = new System.Drawing.Size(43, 43);
            this.casita.TabIndex = 0;
            this.casita.UseVisualStyleBackColor = false;
            this.casita.Click += new System.EventHandler(this.casita_Click);
            // 
            // subirito
            // 
            this.subirito.BackgroundImage = global::StudyOrt.Properties.Resources.share;
            this.subirito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.subirito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subirito.Location = new System.Drawing.Point(1, 179);
            this.subirito.Name = "subirito";
            this.subirito.Size = new System.Drawing.Size(43, 43);
            this.subirito.TabIndex = 1;
            this.subirito.UseVisualStyleBackColor = true;
            this.subirito.Click += new System.EventHandler(this.subirito_Click);
            // 
            // perfilito
            // 
            this.perfilito.BackgroundImage = global::StudyOrt.Properties.Resources.person1;
            this.perfilito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.perfilito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.perfilito.Location = new System.Drawing.Point(1, 259);
            this.perfilito.Name = "perfilito";
            this.perfilito.Size = new System.Drawing.Size(43, 43);
            this.perfilito.TabIndex = 2;
            this.perfilito.UseVisualStyleBackColor = true;
            this.perfilito.Click += new System.EventHandler(this.button3_Click);
            // 
            // cerrarsesionito
            // 
            this.cerrarsesionito.BackgroundImage = global::StudyOrt.Properties.Resources.system_uicons_exit_left__1_;
            this.cerrarsesionito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrarsesionito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarsesionito.Location = new System.Drawing.Point(1, 379);
            this.cerrarsesionito.Name = "cerrarsesionito";
            this.cerrarsesionito.Size = new System.Drawing.Size(43, 43);
            this.cerrarsesionito.TabIndex = 3;
            this.cerrarsesionito.UseVisualStyleBackColor = true;
            this.cerrarsesionito.Click += new System.EventHandler(this.button4_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyOrt.Properties.Resources.dancarcel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cerrarsesionito);
            this.Controls.Add(this.perfilito);
            this.Controls.Add(this.subirito);
            this.Controls.Add(this.casita);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.nameSurname);
            this.DoubleBuffered = true;
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameSurname;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button perfilito;
        private System.Windows.Forms.Button cerrarsesionito;
        private System.Windows.Forms.Button casita;
        private System.Windows.Forms.Button subirito;
    }
}