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
        ClsSesion ses = new ClsSesion();
        FrmConsultaHojaSec frm;

        bool sw = false;
        string ID_Hoja_Sec;

        private void FrmHojaEnfermeria_Load(object sender, EventArgs e)
        {
            dgvHojaEnfermeria.DataSource = enf.Mostrar_Registros();
            dgvHojaEnfermeria.DataMember = "tac";
            dgvHojaEnfermeria.AutoResizeColumns();
            dgvHojaEnfermeria.AutoResizeRows();
        }        
                

        private void LimpiarTexto()
        {
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
        }
        
        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (sw == true)
                {
                    enf.Nro_Sesion_HD = txtNumSesion.Text;
                    enf.Hora_Inicio = dtpHoraInicio.Text;
                    enf.Hora_Salida = dtpHoraSalida.Text;
                    enf.U_F_Programada1 = txtUFProg.Text;
                    enf.Heparina = txtHeparina.Text;
                    enf.Flujo_Efectivo = txtFlujoEfect.Text;
                    enf.Presion_Arterial = txtPresionArt.Text;
                    enf.Temperatura = txtTemp.Text;
                    enf.Pulso = txtPulso.Text;
                    enf.Saturacion = txtSaturacion.Text;
                    enf.Id_sesion = "";
                    enf.Guardar_Registros();

                    ses.Fecha_Sesion = dtpFechaSesion.Text;
                    ses.Peso_Inicial = txtPesoIni.Text;
                    ses.Peso_Final = txtPesoFin.Text;
                    ses.Id_empleado = Constantes.ID_Emp;
                    ses.Id_hojaS = ID_Hoja_Sec;
                    ses.Id_nota = "";
                    ses.Guardar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Insertado correctamente", "INFORMACION");
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

        private void btnMostrarRegistros_Click_1(object sender, EventArgs e)
        {
            dgvHojaEnfermeria.DataSource = enf.Mostrar_Registros();
            dgvHojaEnfermeria.DataMember = "tac";
            dgvHojaEnfermeria.AutoResizeColumns();
            dgvHojaEnfermeria.AutoResizeRows();
        }

        private void btnSelectHojaSec_Click(object sender, EventArgs e)
        {
            frm = new FrmConsultaHojaSec();
            frm.dgvConsultaHojaSec.CellMouseDoubleClick += DgvConsultaHojaSec_CellMouseDoubleClick;
            frm.ShowDialog();
            sw = true;
        }

        private void DgvConsultaHojaSec_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //Obtengo el valor de ID Hoja Secretaria en una variable string
            ID_Hoja_Sec = dgv[0, e.RowIndex].Value.ToString().Trim();
            frm.Close();
        }
    }
}