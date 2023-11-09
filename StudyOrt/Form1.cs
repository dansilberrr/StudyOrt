using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudyOrt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";
        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtBxDni.Text == "" || TxtBxContra.Text == "")
            {
                MessageBox.Show("Dni o Contraseña vacíos", "Login Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBxDni.Focus();
            }
            else
            {
                con.Open();
                string login = "SELECT * FROM users WHERE DNI= " + TxtBxDni.Text + " and PASSWORD= '" + TxtBxContra.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Login");

                if (ds.Tables["Login"].Rows.Count == 1)
                {
                    Form3 f3 = new Form3();
                    f3.USUARIO = TxtBxDni.Text;
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dni o Contraseña inválidos. Volvé a intentar.", "Login Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtBxDni.Text = "";
                    TxtBxContra.Text = "";
                    TxtBxDni.Focus();

                }
                con.Close();

            }

        }




        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void chkBoxmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxmostrar.Checked)
            {
                TxtBxContra.PasswordChar = '\0';

            }
            else
            {
                TxtBxContra.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtBxDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
