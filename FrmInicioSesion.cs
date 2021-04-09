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

namespace Clinica_Nefroone
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }



        private void logins()
        {
            /*try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    using (SqlCommand cmd = new SqlCommand("SELEC Usuario, pass FROM Usuarios Where usuario=" + txtUser.Text + "' AND pass='" + txtPass.Text));
                }
            }
            catch (Exception ex)
            { 
                
            }*/
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
