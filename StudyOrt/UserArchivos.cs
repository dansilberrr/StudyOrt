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
using System.Runtime.CompilerServices;

namespace StudyOrt
{

    public partial class UserControl1 : UserControl
    {
        [Category("Custom Props")]
        private string _nombre;
        private string _tema;
        private string _aclaraciones;
        private string _url;
        private string _fecha;

        [Category("Custom Props")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; lblNombre.Text = value; }
        }
        [Category("Custom Props")]
        public string tema
        {
            get { return _tema; }
            set { _tema = value; lblTema.Text = value; }
        }
        [Category("Custom Props")]
        public string Aclaraciones
        {
            get { return _aclaraciones; }
            set { _aclaraciones = value; lblAcl.Text = value; }
        }
        [Category("Custom Props")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        [Category("Custom Props")]
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; lblFecha.Text = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDescArchivo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_url);

        }
    }
}