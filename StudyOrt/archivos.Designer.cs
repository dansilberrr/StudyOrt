
namespace StudyOrt
{
    partial class archivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archivos));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.LblAño = new System.Windows.Forms.Label();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenu.Controls.Add(this.LblAño);
            this.PanelMenu.Controls.Add(this.BtnLogOut);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.BtnPerfil);
            this.PanelMenu.Controls.Add(this.BtnSubir);
            this.PanelMenu.Controls.Add(this.BtnInicio);
            this.PanelMenu.Location = new System.Drawing.Point(-5, 1);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(154, 597);
            this.PanelMenu.TabIndex = 1;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.BackColor = System.Drawing.Color.Transparent;
            this.LblAño.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.Location = new System.Drawing.Point(54, 21);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(47, 22);
            this.LblAño.TabIndex = 1;
            this.LblAño.Text = "label3";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogOut.BackgroundImage")));
            this.BtnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.Location = new System.Drawing.Point(53, 465);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(43, 43);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.BtnPerfil.BackgroundImage = global::StudyOrt.Properties.Resources.person1;
            this.BtnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPerfil.Location = new System.Drawing.Point(53, 331);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(43, 43);
            this.BtnPerfil.TabIndex = 2;
            this.BtnPerfil.UseVisualStyleBackColor = false;
            this.BtnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // BtnSubir
            // 
            this.BtnSubir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSubir.BackgroundImage")));
            this.BtnSubir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubir.Location = new System.Drawing.Point(53, 235);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(43, 43);
            this.BtnSubir.TabIndex = 1;
            this.BtnSubir.UseVisualStyleBackColor = true;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInicio.BackgroundImage")));
            this.BtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.Location = new System.Drawing.Point(53, 141);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(43, 43);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(155, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 597);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyOrt.Properties.Resources.FONDOPRIMERAÑO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 597);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PanelMenu);
            this.DoubleBuffered = true;
            this.Name = "archivos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.archivos_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPerfil;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}