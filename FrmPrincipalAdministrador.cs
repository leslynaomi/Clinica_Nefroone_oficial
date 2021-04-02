using capa_presentacion.Usuarios.Enfermero;
using capa_presentacion.Usuarios.Medico;
using capa_presentacion.Usuarios.secretario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using capa_presentacion;

namespace capa_presentacion
{
    public partial class FrmPrincipalAdministrador : Form
    {
        public FrmPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void FrmPrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludMenu_Click(object sender, EventArgs e)
        {
            FrmAreaSalud frm = new FrmAreaSalud();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnSecretaria_Click(object sender, EventArgs e)
        {
            this.Hide();

            formularioprincipalS frm = new formularioprincipalS();
            frm.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            this.Hide();

            menuprincipalM frm = new menuprincipalM();
            frm.Show();
        }

        private void btnEnfermera_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            formularioprincipalE frm = new formularioprincipalE();
            frm.Show();
        }
    }
}
