
namespace StudyOrt
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.BtnPrimerAño = new System.Windows.Forms.Button();
            this.BtnSegundoAño = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrimerAño
            // 
            this.BtnPrimerAño.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrimerAño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrimerAño.BackgroundImage")));
            this.BtnPrimerAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrimerAño.FlatAppearance.BorderSize = 0;
            this.BtnPrimerAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrimerAño.Location = new System.Drawing.Point(268, 193);
            this.BtnPrimerAño.Name = "BtnPrimerAño";
            this.BtnPrimerAño.Size = new System.Drawing.Size(397, 94);
            this.BtnPrimerAño.TabIndex = 0;
            this.BtnPrimerAño.UseVisualStyleBackColor = false;
            this.BtnPrimerAño.Click += new System.EventHandler(this.BtnPrimerAño_Click);
            // 
            // BtnSegundoAño
            // 
            this.BtnSegundoAño.BackColor = System.Drawing.Color.Transparent;
            this.BtnSegundoAño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSegundoAño.BackgroundImage")));
            this.BtnSegundoAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSegundoAño.FlatAppearance.BorderSize = 0;
            this.BtnSegundoAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSegundoAño.Location = new System.Drawing.Point(268, 315);
            this.BtnSegundoAño.Name = "BtnSegundoAño";
            this.BtnSegundoAño.Size = new System.Drawing.Size(397, 96);
            this.BtnSegundoAño.TabIndex = 1;
            this.BtnSegundoAño.UseVisualStyleBackColor = false;
            this.BtnSegundoAño.Click += new System.EventHandler(this.BtnSegundoAño_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.BtnSegundoAño);
            this.Controls.Add(this.BtnPrimerAño);
            this.Name = "Form3";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrimerAño;
        private System.Windows.Forms.Button BtnSegundoAño;
    }
}