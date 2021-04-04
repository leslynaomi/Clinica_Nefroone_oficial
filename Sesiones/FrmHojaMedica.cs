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
    public partial class FrmHojaMedica : Form
    {
        public FrmHojaMedica()
        {
            InitializeComponent();
        }

        ClsHojaMedica med = new ClsHojaMedica();

        private void btnMenuPacientes_Click(object sender, EventArgs e)
        {
            FrmGestionarPaciente frm = new FrmGestionarPaciente();
            frm.Show();
        }

        private void FrmHojaMedica_Load(object sender, EventArgs e)
        {
            dgvHojaMedica.DataSource = med.Mostrar_Registros();
            dgvHojaMedica.DataMember = "tac";
            dgvHojaMedica.AutoResizeColumns();
            dgvHojaMedica.AutoResizeRows();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvHojaMedica.DataSource = med.Mostrar_Registros();
            dgvHojaMedica.DataMember = "tac";
            dgvHojaMedica.AutoResizeColumns();
            dgvHojaMedica.AutoResizeRows();
        }

        private void btnMenuEmp_Click(object sender, EventArgs e)
        {
            FrmGestionarEmpleado frmEmp = new FrmGestionarEmpleado();
            frmEmp.Show();
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = med.Buscar_Registros(txtParamBusc.Text);
            dgvHojaMedica.DataSource = ds;
            dgvHojaMedica.DataMember = "tac";
            dgvHojaMedica.AutoResizeColumns();
            dgvHojaMedica.AutoResizeRows();
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {                
                med.Nro_Uso_Filtro = txtNumUsoFiltro.Text;
                med.Diagnostico = txtDiagnostic.Text;
                med.Peso_Seco = txtPesoSeco.Text;
                med.Serologia = txtSerologia.Text;
                med.Talla = txtTalla.Text;
                med.Imc = txtIMC.Text;
                med.Vih = chkVIH.Checked;
                med.Acceso_Vascular = txtAccesoVascular.Text;
                med.Grupo_Sanguineo = txtGrupoSang.Text;
                med.Solucion_Dializante = txtSolDial.Text;
                med.Id_empleado = txtIDEmp.Text;
                med.Guardar_Registros();
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
            txtIDEmp.Clear();
            txtNumUsoFiltro.Clear();
            txtDiagnostic.Clear();
            txtPesoSeco.Clear();
            txtSerologia.Clear();
            txtTalla.Clear();
            txtIMC.Clear();
            chkVIH.ResetText();
            txtAccesoVascular.Clear();
            txtGrupoSang.Clear();
            txtSolDial.Clear();
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDEmp.Text == "" || txtParamModElim.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de ID de la hoja médica y un ID de empleado para poder proceder");
                }
                else
                {
                    med.Id_empleado = txtIDEmp.Text;
                    med.Nro_Uso_Filtro = txtNumUsoFiltro.Text;
                    med.Diagnostico = txtDiagnostic.Text;
                    med.Peso_Seco = txtPesoSeco.Text;
                    med.Serologia = txtSerologia.Text;
                    med.Talla = txtTalla.Text;
                    med.Imc = txtIMC.Text;
                    med.Vih = chkVIH.Checked;
                    med.Acceso_Vascular = txtAccesoVascular.Text;
                    med.Grupo_Sanguineo = txtGrupoSang.Text;
                    med.Solucion_Dializante = txtSolDial.Text;
                    med.Id_empleado = txtIDEmp.Text;
                    med.Modificar_Registros();
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
                if (txtIDEmp.Text == "" || txtParamModElim.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de ID de la hoja médica y un ID de empleado para poder proceder");
                }
                else 
                {
                    med.Id_hojaM = txtParamModElim.Text;
                    med.Id_empleado = txtIDEmp.Text;
                    med.Eliminar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Eliminado correctamente", "INFORMACION");
                }                
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }
    }
}
