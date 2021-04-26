using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_negocio;

namespace capa_presentacion
{
    public partial class FrmConsultaSesion : Form
    {
        public FrmConsultaSesion()
        {
            InitializeComponent();
        }

        ClsSesion ses = new ClsSesion();     

        private void txtbuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ses.Buscar_Registros(btnBuscarRegistros.Text);
            dgvConsultaSesion.DataSource = ds;
            dgvConsultaSesion.DataMember = "tac";
            dgvConsultaSesion.AutoResizeColumns();
            dgvConsultaSesion.AutoResizeRows();
        }      

        private void dgvSesion_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void FrmSesion_Load(object sender, EventArgs e)
        {
            dgvConsultaSesion.DataSource = ses.Mostrar_Registros();
            dgvConsultaSesion.DataMember = "tac";
            dgvConsultaSesion.AutoResizeColumns();
            dgvConsultaSesion.AutoResizeRows();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvConsultaSesion.DataSource = ses.Mostrar_Registros();
            dgvConsultaSesion.DataMember = "tac";
            dgvConsultaSesion.AutoResizeColumns();
            dgvConsultaSesion.AutoResizeRows();
        }
    }
}
