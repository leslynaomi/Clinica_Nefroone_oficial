using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

using capa_datos;
using capa_negocio;

namespace capa_presentacion
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        
        FrmPrincipalAdministrador frm1 = new FrmPrincipalAdministrador();

        void p_login()
        {
            DataTable dt = new DataTable();
            objeuser.Usuario = txtUsuario.Text;
            objeuser.Contraseña = txtContraseña.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("bienvenido ");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalida");
            }
        }    
        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            p_login();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipalAdministrador frm = new FrmPrincipalAdministrador();
            frm.Show();
        }
    }
}
