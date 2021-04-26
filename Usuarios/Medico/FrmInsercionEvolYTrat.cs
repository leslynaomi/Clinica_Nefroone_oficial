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
    public partial class FrmInsercionEvolYTrat : Form
    {
        public FrmInsercionEvolYTrat()
        {
            InitializeComponent();
        }
        
        //Instancio los formularios que voy a llamar con botones y de los cuales voy a robar datos
        FrmConsultaSesion frm;

        //Instancia de la clase necesaria para ejecutar las inserciones de registros Evolución y Tratamiento
        ClsEvoloucionYTratamiento evol = new ClsEvoloucionYTratamiento();
        
        //Switch sencillo que me indica si ya he seleccionado un paciente para poder insertar datos
        bool sw = false;
        
        //Variables string donde voy a capturar los datos para mostrar en los label's
        string ID_Sesion;
        string Paciente;
        string CI;
        string Edad;
        string Sexo;
        string Seguro;
        
        private void FrmInsercionEvoloucionYTratamiento_Load(object sender, EventArgs e)
        {
            
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
                    evol.Id_sesion = ID_Sesion;
                    evol.Id_empleado = Constantes.ID_Emp;
                    evol.Guardar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Insertado correctamente", "INFORMACION");
                    //sw = false;
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
            cbxDuracion.ResetText();
            txtFlujoDial.Clear();
            rtbEvolClin.ResetText();
            txtNroUsoFiltro.Clear();
            txtDiagnostic.Clear();
            txtPesoSeco.Clear();
            txtSerologia.Clear();
            txtTalla.Clear();
            txtIMC.Clear();
            chkVIH.ResetText();
            txtGrupoSang.Clear();
            txtSolDial.Clear();
        }

        private void btnSelectSesion_Click(object sender, EventArgs e)
        {
                frm = new FrmConsultaSesion();
                frm.dgvConsultaSesion.CellMouseDoubleClick += DgvSesion_CellMouseDoubleClick;
                frm.ShowDialog();
                sw = true;            
        }

        private void DgvSesion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            
            //Obtengo el valor de ID sesión en una variable string
            ID_Sesion = dgv[0, e.RowIndex].Value.ToString().Trim();
            Paciente = dgv[3, e.RowIndex].Value.ToString().Trim() + " " + dgv[4, e.RowIndex].Value.ToString().Trim() + " " + dgv[5, e.RowIndex].Value.ToString().Trim();
            CI = dgv[2, e.RowIndex].Value.ToString().Trim();
            Edad = dgv[6, e.RowIndex].Value.ToString().Trim();
            Sexo = dgv[7, e.RowIndex].Value.ToString().Trim();
            Seguro = dgv[8, e.RowIndex].Value.ToString().Trim();

            //Asigno los valores relevantes a los label, meramente informativos, mostrar datos
            lbPaciente.Text = lbPaciente.Text + Paciente;
            lbCi.Text = lbCi.Text + CI;
            lbEdad.Text = lbEdad.Text + Edad;
            lbSexo.Text = lbSexo.Text + Sexo;
            lbSeguro.Text = lbSeguro.Text + Seguro;

            frm.Close();
        }
    }
}
