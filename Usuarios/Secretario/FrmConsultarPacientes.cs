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
    public partial class FrmConsultarPacientes : Form
    {
        public FrmConsultarPacientes()
        {
            InitializeComponent();
        }

        ClsPaciente pac = new ClsPaciente();
        
        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = pac.Buscar_Registros(txtParam.Text);
            dgvPaciente.DataSource = ds;
            dgvPaciente.DataMember = "tac";
            dgvPaciente.AutoResizeColumns();
            dgvPaciente.AutoResizeRows();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvPaciente.DataSource = pac.Mostrar_Registros();
            dgvPaciente.DataMember = "tac";
            dgvPaciente.AutoResizeColumns();
            dgvPaciente.AutoResizeRows();
        }
    }
}
