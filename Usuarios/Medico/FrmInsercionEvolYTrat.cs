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
    public partial class FrmInsercionEvoloucionYTratamiento : Form
    {
        public FrmInsercionEvoloucionYTratamiento()
        {
            InitializeComponent();
        }

        ClsEvoloucionYTratamiento evol = new ClsEvoloucionYTratamiento();
        bool sw = false;

        private void FrmInsercionEvoloucionYTratamiento_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMenuPac_Click(object sender, EventArgs e)
        {
            FrmRegistrarPacientes frmPac = new FrmRegistrarPacientes();
            frmPac.Show();
        }               

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if(sw==true)
                {
                    evol.Duracion = cbxDuracion.Text;
                    evol.Flujo_Dialisis = txtFlujoDial.Text;
                    evol.Evolucion_Clinica = rtbEvolClin.Text;
                    evol.Nro_Uso_Filtro = txtNroUsoFiltro.Text;
                    evol.Diagnostico = txtDiagnostic.Text;
                    evol.Peso_Seco = txtPesoSeco.Text;
                    evol.Serologia = txtSerologia.Text;
                    evol.Talla = txtTalla.Text;
                    evol.Imc = txtIMC.Text;
                    evol.Vih = chkVIH.Checked;
                    evol.Grupo_Sanguineo = txtGrupoSang.Text;
                    evol.Solucion_Dializante = txtSolDial.Text;
                    evol.Id_sesion = Constantes.ID_Sesion;
                    evol.Id_empleado = Constantes.ID_Emp;
                    evol.Guardar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Insertado correctamente", "INFORMACION");
                    sw = false;
                }
                else
                {
                    MessageBox.Show("Necesita escoger un paciente para asignarle esta hoja de evolución y tratamiento", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }

        private void LimpiarTexto()
        {
            /*txtNroSeguro.Clear();
            txtUltraFil.Clear();
            cbxDuracion.ResetText();
            txtFlujoDial.Clear();
            rtbEvolClin.Clear();
            txtNroUsoFiltro.Clear();
            txtTipoTrat.Clear();
            txtIDHojaEnf.Clear();
            txtIDEmp.Clear();
            txtParamBusc.Clear();
            txtParamModElim.Clear();*/
        }

        private void btnSelectSesion_Click(object sender, EventArgs e)
        {            
            sw = true;
        }
    }
}
