using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class FrmConsultaHojaSec : Form
    {
        public FrmConsultaHojaSec()
        {
            InitializeComponent();
        }

        ClsHojaSecretaria sec = new ClsHojaSecretaria();
        
        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvConsultaHojaSec.DataSource = sec.Mostrar_HojaSec();
            dgvConsultaHojaSec.DataMember = "tac";
            dgvConsultaHojaSec.AutoResizeColumns();
            dgvConsultaHojaSec.AutoResizeRows();
        }
    }
}
