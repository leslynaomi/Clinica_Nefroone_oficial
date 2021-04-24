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
    public partial class FrmConsultaEvolYTrat : Form
    {
        public FrmConsultaEvolYTrat()
        {
            InitializeComponent();
        }
        
        ClsEvoloucionYTratamiento evol = new ClsEvoloucionYTratamiento();

        private void FrmConsultaEvolYTrat_Load(object sender, EventArgs e)
        {
            dgvHojaEvolucionTrat.DataSource = evol.Mostrar_Registros();
            dgvHojaEvolucionTrat.DataMember = "tac";
            dgvHojaEvolucionTrat.AutoResizeColumns();
            dgvHojaEvolucionTrat.AutoResizeRows();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvHojaEvolucionTrat.DataSource = evol.Mostrar_Registros();
            dgvHojaEvolucionTrat.DataMember = "tac";
            dgvHojaEvolucionTrat.AutoResizeColumns();
            dgvHojaEvolucionTrat.AutoResizeRows();
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = evol.Buscar_Registros(txtParamBusc.Text);
            dgvHojaEvolucionTrat.DataSource = ds;
            dgvHojaEvolucionTrat.DataMember = "tac";
            dgvHojaEvolucionTrat.AutoResizeColumns();
            dgvHojaEvolucionTrat.AutoResizeRows();
        }
    }
}
