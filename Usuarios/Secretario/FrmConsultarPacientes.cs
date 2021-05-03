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
            if (rdbName.Checked == true || rdbApellido.Checked == true || rdbEdad.Checked == true || rdbCi.Checked == true)
            {
                if (rdbName.Checked == true)
                { ds = pac.Buscar_Nombre(txtParam.Text); }

                if (rdbApellido.Checked == true)
                { ds = pac.Buscar_Apellido(txtParam.Text); }

                if (rdbEdad.Checked == true)
                { ds = pac.Buscar_Edad(txtParam.Text); }

                if (rdbCi.Checked == true)
                { ds = pac.Buscar_Ci(txtParam.Text); }

                dgvPaciente.DataSource = ds;
                dgvPaciente.DataMember = "tac";
                dgvPaciente.AutoResizeColumns();
                dgvPaciente.AutoResizeRows();
            }            
            else
            {
                MessageBox.Show("Tiene que seleccionar una opción de búsqueda");
            }
        }        
    }
}
