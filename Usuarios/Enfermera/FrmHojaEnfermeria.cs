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
    public partial class FrmHojaEnfermeria : Form
    {
        public FrmHojaEnfermeria()
        {
            InitializeComponent();
        }

        ClsHojaEnfermeria enf = new ClsHojaEnfermeria();     

        private void FrmHojaEnfermeria_Load(object sender, EventArgs e)
        {
            dgvHojaEnfermeria.DataSource = enf.Mostrar_Registros();
            dgvHojaEnfermeria.DataMember = "tac";
            dgvHojaEnfermeria.AutoResizeColumns();
            dgvHojaEnfermeria.AutoResizeRows();
        }        

        private void btnInsertarRegistros_Click_1(object sender, EventArgs e)
        {
            try
            {
                enf.Fecha_Sesion = dtpFechaSesion.Text;
                enf.Nro_Sesion_HD = txtNumSesion.Text;
                enf.Hora_Inicio = dtpHoraInicio.Text;
                enf.Hora_Salida = dtpHoraSalida.Text;
                enf.Peso_Inicial = txtPesoIni.Text;
                enf.Peso_Final = txtPesoFin.Text;
                enf.U_F_Programada1 = txtUFProg.Text;
                enf.Heparina = txtHeparina.Text;
                enf.Flujo_Efectivo = txtFlujoEfect.Text;
                enf.Presion_Arterial = txtPresionArt.Text;
                enf.Temperatura = txtTemp.Text;
                enf.Pulso = txtPulso.Text;
                enf.Saturacion = txtSaturacion.Text;
                enf.Id_hojaS = txtNroHojReg.Text;
                enf.Id_empleado = txtIDEmp.Text;
                enf.Guardar_Registros();
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
            txtParamBusc.Clear();
            txtParamModElim.Clear();
            dtpFechaSesion.ResetText();
            txtNumSesion.Clear();
            dtpHoraInicio.ResetText();
            dtpHoraSalida.ResetText();
            txtPesoIni.Clear();
            txtPesoFin.Clear();
            txtUFProg.Clear();
            txtHeparina.Clear();
            txtFlujoEfect.Clear();
            txtPresionArt.Clear();
            txtTemp.Clear();
            txtPulso.Clear();
            txtSaturacion.Clear();
            txtNroHojReg.Clear();
            txtIDEmp.Clear();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvHojaEnfermeria.DataSource = enf.Mostrar_Registros();
            dgvHojaEnfermeria.DataMember = "tac";
            dgvHojaEnfermeria.AutoResizeColumns();
            dgvHojaEnfermeria.AutoResizeRows();
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEmp.Text == "" || txtNroHojReg.Text == "" || txtParamModElim.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de Nº de hoja registro, una ID de la Hoja de Control de Enfermería y un ID de empleado para poder proceder");
                }
                else 
                {
                    enf.Id_hoja_enfermeria = txtParamModElim.Text;
                    enf.Fecha_Sesion = dtpFechaSesion.Text;
                    enf.Nro_Sesion_HD = txtNumSesion.Text;
                    enf.Hora_Inicio = dtpHoraInicio.Text;
                    enf.Hora_Salida = dtpHoraSalida.Text;
                    enf.Peso_Inicial = txtPesoIni.Text;
                    enf.Peso_Final = txtPesoFin.Text;
                    enf.U_F_Programada1 = txtUFProg.Text;
                    enf.Heparina = txtHeparina.Text;
                    enf.Flujo_Efectivo = txtFlujoEfect.Text;
                    enf.Presion_Arterial = txtPresionArt.Text;
                    enf.Temperatura = txtTemp.Text;
                    enf.Pulso = txtPulso.Text;
                    enf.Saturacion = txtSaturacion.Text;
                    enf.Id_hojaS = txtNroHojReg.Text;
                    enf.Id_empleado = txtIDEmp.Text;
                    enf.Modificar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Modificado correctamente", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al modificar" + er.ToString());
            }
        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEmp.Text == "" || txtNroHojReg.Text == "" || txtParamModElim.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de Nº de hoja registro, una ID de la Hoja de Control de Enfermería y un ID de empleado para poder proceder");
                }
                else
                {
                    enf.Id_hoja_enfermeria = txtParamModElim.Text;
                    enf.Id_hojaS = txtNroHojReg.Text;
                    enf.Id_empleado = txtIDEmp.Text;
                    enf.Eliminar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Eliminado correctamente", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void btnMenuPacientes_Click(object sender, EventArgs e)
        {
            FrmRegistrarPacientes frmPac = new FrmRegistrarPacientes();
            frmPac.Show();                        
        }

        private void btnMenuEmpelados_Click(object sender, EventArgs e)
        {


            this.Close();

            FrmPrincipalAdministrador frm = new FrmPrincipalAdministrador();
            frm.Show();
            ////7/FrmGestionarEmpleado frmEmp = new FrmGestionarEmpleado();
            ///  frmEmp.Show();  
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = enf.Buscar_Registros(txtParamBusc.Text);
            dgvHojaEnfermeria.DataSource = ds;
            dgvHojaEnfermeria.DataMember = "tac";
            dgvHojaEnfermeria.AutoResizeColumns();
            dgvHojaEnfermeria.AutoResizeRows();
        }

        private void bDIALISISPERITONEAL_Click(object sender, EventArgs e)
        {
            FrmDialisisPeritoneal frm = new FrmDialisisPeritoneal();
            frm.Show();
        }
    }
}