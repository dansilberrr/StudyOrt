﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace StudyOrt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public const string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = .\\StudyOrtDB.accdb;Persist Security Info=False;";
        OleDbConnection con = new OleDbConnection(connString);
        OleDbCommand cmd;


        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            if (TxtBoxNombre.Text == "" || TxtBoxApellido.Text == "" || TxtBoxDni.Text == "" || TxtBoxContaseña.Text == "" || TxtBoxRepContraseña.Text == "")
            {
                MessageBox.Show("Algún campo esta vacío", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtBoxContaseña.Text == TxtBoxRepContraseña.Text)
            {
                con.Open();

                string dni = "SELECT * FROM users WHERE DNI = " + TxtBoxDni.Text;
                cmd = new OleDbCommand(dni, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "dni");

                if (ds.Tables["dni"].Rows.Count == 1)
                {
                    MessageBox.Show("La cuenta ya existe", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string register = "INSERT INTO users VALUES (" + TxtBoxDni.Text + ",'" + TxtBoxContaseña.Text + "','" + TxtBoxNombre.Text + "','" + TxtBoxApellido.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tu cuenta ha sido registrada", "Registración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                con.Close();
                TxtBoxNombre.Text = "";
                TxtBoxApellido.Text = "";
                TxtBoxDni.Text = "";
                TxtBoxContaseña.Text = "";
                TxtBoxRepContraseña.Text = "";


            }
            else
            {
                MessageBox.Show("Las contraseñas no coiniciden, volvé a intentar", "Registación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBoxContaseña.Text = "";
                TxtBoxRepContraseña.Text = "";
                TxtBoxContaseña.Focus();
            }


        }

        private void chkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxMostrar.Checked)
            {
                TxtBoxContaseña.PasswordChar = '\0';
                TxtBoxRepContraseña.PasswordChar = '\0';
            }
            else
            {
                TxtBoxContaseña.PasswordChar = '*';
                TxtBoxRepContraseña.PasswordChar = '*';
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
