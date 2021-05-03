using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            if (rdbFechaSesion.Checked == true || rdbAccesoVasc.Checked == true || rdbGrupSang.Checked == true || rdbVIH.Checked == true || rdbNameMed.Checked == true || rdbApellidoMed.Checked == true)
            {
                DataSet ds = new DataSet();                
                if (rdbFechaSesion.Checked == true)
                {
                    ds = evol.Buscar_fecha_Sesion(dtpFechaSes.Text);
                }                
                if (rdbAccesoVasc.Checked == true)
                {
                    ds = evol.Buscar_acceso_Vascular(cbxAccesoV.Text);
                }
                if (rdbGrupSang.Checked == true)
                {
                    ds = evol.Buscar_grupo_Sanguineo(txtParamBusc.Text);
                }
                if (rdbVIH.Checked == true)
                {
                    if(cbxVIH.Text == "Positivo")
                    {
                        ds = evol.Buscar_VIH("1");
                    }
                    else
                    {
                        ds = evol.Buscar_VIH("0");
                    }
                }
                if (rdbNameMed.Checked == true)
                {
                    ds = evol.Buscar_nombre_Medico(txtParamBusc.Text);
                }
                if (rdbApellidoMed.Checked == true)
                {
                    ds = evol.Buscar_apellido_Medico(txtParamBusc.Text);
                }
                dgvHojaEvolucionTrat.DataSource = ds;
                dgvHojaEvolucionTrat.DataMember = "tac";
                dgvHojaEvolucionTrat.AutoResizeColumns();
                dgvHojaEvolucionTrat.AutoResizeRows();
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una opción de búsqueda");
            }
        }

        private void rdbFechaSesion_CheckedChanged(object sender, EventArgs e)
        {
            txtParamBusc.Visible = false;
            cbxVIH.Visible = false;
            cbxAccesoV.Visible = false;
            dtpFechaSes.Visible = true;
        }

        private void rdbAccesoVasc_CheckedChanged(object sender, EventArgs e)
        {
            txtParamBusc.Visible = false;
            cbxVIH.Visible = false;
            dtpFechaSes.Visible = false;
            cbxAccesoV.Visible = true;
        }

        private void rdbVIH_CheckedChanged(object sender, EventArgs e)
        {
            txtParamBusc.Visible = false;
            dtpFechaSes.Visible = false;
            cbxAccesoV.Visible = false;
            cbxVIH.Visible = true;
        }

        private void rdbGrupSang_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaSes.Visible = false;
            cbxAccesoV.Visible = false;
            cbxVIH.Visible = false;
            txtParamBusc.Visible = true;
        }

        private void rdbNameMed_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaSes.Visible = false;
            cbxAccesoV.Visible = false;
            cbxVIH.Visible = false;
            txtParamBusc.Visible = true;
        }

        private void rdbApellidoMed_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaSes.Visible = false;
            cbxAccesoV.Visible = false;
            cbxVIH.Visible = false; 
            txtParamBusc.Visible = true;
        }
    }
}
