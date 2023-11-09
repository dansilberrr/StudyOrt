using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Threading;

namespace StudyOrt
{
    public partial class archivos : Form
    {
        public string USUARIO;

        public string curso;


        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";

        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;


        public archivos(string palabra)
        {
            InitializeComponent();
            PanelMenu.Visible = true;
            curso = palabra;

        }

        

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.USUARIO = USUARIO;
            F3.Show();
            this.Hide();
        }

        private void archivos_Load(object sender, EventArgs e)
        {
            if (curso == "Primero")
            {
                LblAño.Text = "1° Año";
                 flowLayoutPanel1.BackgroundImage = StudyOrt.Properties.Resources.FONDOPRIMERAÑO1;
                PanelMenu.BackColor = Color.FromArgb(70, 254, 254, 254);

            }
            else
            {
                LblAño.Text = "2° Año";
                PanelMenu.BackColor = Color.FromArgb(70, 254, 254, 254);
                flowLayoutPanel1.BackgroundImage = StudyOrt.Properties.Resources.SEGUNDOAÑOFONDO;
            }

            con.Open();

            string SQL = "SELECT F.*, U.NOMBRE AS NOMBRE_USUARIO, U.APELLIDO AS APELLIDO_USUARIO FROM files F INNER JOIN USERS U ON F.DNI = U.DNI WHERE F.YEAR = \"" + curso + "\"";
            cmd = new OleDbCommand(SQL, con);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "info");



            for (int i = 0; i < ds.Tables["info"].Rows.Count; i++)
            {
                UserControl1 uc = new UserControl1();
                uc.Nombre = string.Format("{0} {1}", ds.Tables["info"].Rows[i][8].ToString(), ds.Tables["info"].Rows[i][9].ToString());
                uc.tema = ds.Tables["info"].Rows[i][1].ToString();
                uc.Aclaraciones = ds.Tables["info"].Rows[i][2].ToString();
                uc.Fecha = ds.Tables["info"].Rows[i][3].ToString();
                uc.Url = ds.Tables["info"].Rows[i][4].ToString();
                uc.Materia = ds.Tables["info"].Rows[i][7].ToString();
                uc.Margin = new Padding(10, 10, 10, 10); 


                flowLayoutPanel1.Controls.Add(uc);

                Thread.Sleep(10);
            }
            con.Close();

            if (USUARIO != null)
            {
                string cmdSQL = "SELECT Nombre, Apellido FROM Users WHERE DNI = " + USUARIO;
                cmd = new OleDbCommand(cmdSQL, con);
                da = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "User");
                string nombre = ds.Tables["User"].Rows[0][0].ToString();
                string apellido = ds.Tables["User"].Rows[0][1].ToString();

                label1.Text = nombre + " " + apellido;
            }
            else
            {
                label1.Text = "Usuario Deesconocido";
            }
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            subir_archivo subir_Archivo = new subir_archivo();
            subir_Archivo.USUARIO = USUARIO;
            subir_Archivo.curso = curso;
            subir_Archivo.Show();
            this.Hide();
        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            USUARIO = string.Empty;
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            Perfil p1 = new Perfil();
            p1.USUARIO = USUARIO;
            p1.curso = curso;
            p1.Show();
            this.Hide();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblAño_Click(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}