
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPerfil = new System.Windows.Forms.Button();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblAño = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.BtnLogOut);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.BtnPerfil);
            this.PanelMenu.Controls.Add(this.BtnSubir);
            this.PanelMenu.Controls.Add(this.BtnInicio);
            this.PanelMenu.Location = new System.Drawing.Point(16, 104);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(107, 428);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(12, 307);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(92, 21);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Cerrar Cesion";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre y Apellido";
            // 
            // BtnPerfil
            // 
            this.BtnPerfil.Location = new System.Drawing.Point(17, 209);
            this.BtnPerfil.Name = "BtnPerfil";
            this.BtnPerfil.Size = new System.Drawing.Size(75, 23);
            this.BtnPerfil.TabIndex = 2;
            this.BtnPerfil.Text = "Perfil";
            this.BtnPerfil.UseVisualStyleBackColor = true;
            this.BtnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // BtnSubir
            // 
            this.BtnSubir.Location = new System.Drawing.Point(17, 142);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(75, 23);
            this.BtnSubir.TabIndex = 1;
            this.BtnSubir.Text = "Subir";
            this.BtnSubir.UseVisualStyleBackColor = true;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnInicio.BackgroundImage = global::StudyOrt.Properties.Resources.Rectangle_75__1_;
            this.BtnInicio.Location = new System.Drawing.Point(17, 81);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(75, 23);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 597);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LblAño);
            this.splitContainer1.Panel1.Controls.Add(this.PanelMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(906, 597);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 3;
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Location = new System.Drawing.Point(50, 52);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(35, 13);
            this.LblAño.TabIndex = 1;
            this.LblAño.Text = "label3";
            // 
            // archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyOrt.Properties.Resources.LOG_IN_LEMON_pasar__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 597);
            this.Controls.Add(this.splitContainer1);
            this.Name = "archivos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.archivos_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPerfil;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LblAño;
    }
}