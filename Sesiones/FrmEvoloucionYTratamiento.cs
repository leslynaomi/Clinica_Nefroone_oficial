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
    public partial class FrmEvoloucionYTratamiento : Form
    {
        public FrmEvoloucionYTratamiento()
        {
            InitializeComponent();
        }

        ClsEvoloucionYTratamiento evol = new ClsEvoloucionYTratamiento();        

        private void frmEvoloucionYTratamiento_Load(object sender, EventArgs e)
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

        private void btnMenuPac_Click(object sender, EventArgs e)
        {
            FrmGestionarPaciente frmPac = new FrmGestionarPaciente();
            frmPac.Show();
        }

        private void btnMenuEmp_Click(object sender, EventArgs e)
        {
            FrmGestionarEmpleado frmEmp = new FrmGestionarEmpleado();
            frmEmp.Show();
        }

        private void btnMenuEnf_Click(object sender, EventArgs e)
        {
            FrmHojaEnfermeria frmEnf = new FrmHojaEnfermeria();
            frmEnf.Show();
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

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {                
                evol.Nro_Seguro = txtNroSeguro.Text;
                evol.Ultra_Filtracion = txtUltraFil.Text;
                evol.Duracion = cbxDuracion.Text;
                evol.Flujo_Dialisis = txtFlujoDial.Text;
                evol.Evolucion_Clinica = rtbEvolClin.Text;
                evol.Detalles_Medicacion = txtDetMed.Text;
                evol.Tipo_Tratamiento = txtTipoTrat.Text;
                evol.Id_hoja_enfermeria = txtIDHojaEnf.Text;
                evol.Id_empleado = txtIDEmp.Text;
                evol.Guardar_Registros();
                LimpiarTexto();
                MessageBox.Show("Insertado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }

        private void LimpiarTexto()
        {
            txtNroSeguro.Clear();
            txtUltraFil.Clear();
            cbxDuracion.ResetText();
            txtFlujoDial.Clear();
            rtbEvolClin.Clear();
            txtDetMed.Clear();
            txtTipoTrat.Clear();
            txtIDHojaEnf.Clear();
            txtIDEmp.Clear();
            txtParamBusc.Clear();
            txtParamModElim.Clear();
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEmp.Text == "" || txtIDHojaEnf.Text == "" || txtParamModElim.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de ID de la hoja de evolución y tratamiento, una ID de la Hoja de Control de Enfermería y un ID de empleado para poder proceder");
                }
                else
                {
                    evol.Id_evolucion_tratamiento = txtParamModElim.Text;
                    evol.Nro_Seguro = txtNroSeguro.Text;
                    evol.Ultra_Filtracion = txtUltraFil.Text;
                    evol.Duracion = cbxDuracion.Text;
                    evol.Flujo_Dialisis = txtFlujoDial.Text;
                    evol.Evolucion_Clinica = rtbEvolClin.Text;
                    evol.Detalles_Medicacion = txtDetMed.Text;
                    evol.Tipo_Tratamiento = txtTipoTrat.Text;
                    evol.Id_hoja_enfermeria = txtIDHojaEnf.Text;
                    evol.Id_empleado = txtIDEmp.Text;
                    evol.Modificar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Modificado correctamente", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Modificar" + er.ToString());
            }
        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEmp.Text == "" || txtIDHojaEnf.Text == "" || txtParamModElim.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de ID de la hoja de evolución y tratamiento, una ID de la Hoja de Control de Enfermería y un ID de empleado para poder proceder");
                }
                evol.Id_evolucion_tratamiento = txtParamModElim.Text;
                evol.Id_hoja_enfermeria = txtIDHojaEnf.Text;
                evol.Id_empleado = txtIDEmp.Text;
                evol.Eliminar_Registros();
                LimpiarTexto();
                MessageBox.Show("Eliminado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }
    }
}
