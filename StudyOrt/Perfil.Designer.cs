
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // nameSurname
            // 
            this.nameSurname.AutoSize = true;
            this.nameSurname.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSurname.Location = new System.Drawing.Point(351, 21);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(34, 29);
            this.nameSurname.TabIndex = 0;
            this.nameSurname.Text = "...";
            this.nameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(360, 50);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(25, 24);
            this.dni.TabIndex = 1;
            this.dni.Text = "...";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(671, 21);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(117, 41);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 351);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.nameSurname);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameSurname;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}