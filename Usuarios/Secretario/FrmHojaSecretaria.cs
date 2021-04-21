using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_datos;
using capa_negocio;

namespace capa_presentacion
{
    public partial class FrmHojaSecretaria : Form
    {
        public FrmHojaSecretaria()
        {
            InitializeComponent();
            //Impedir que se pueda escribir texto en los combobox
            cmbSeguro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        ClsHojaSecretaria sec = new ClsHojaSecretaria();
        ClsPaciente pac = new ClsPaciente();

        private void btnMenuPacientes_Click(object sender, EventArgs e)
        {
            FrmRegistrarPacientes frm = new FrmRegistrarPacientes();
            frm.Show();
        }

        private void FrmHojaSecretaria_Load(object sender, EventArgs e)
        {
            dgvHojaRegistro.DataSource = sec.Mostrar_Registros();
            dgvHojaRegistro.DataMember = "tac";
            dgvHojaRegistro.AutoResizeColumns();
            dgvHojaRegistro.AutoResizeRows();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvHojaRegistro.DataSource = sec.Mostrar_Registros();
            dgvHojaRegistro.DataMember = "tac";
            dgvHojaRegistro.AutoResizeColumns();
            dgvHojaRegistro.AutoResizeRows();
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                pac.Ci = txtCi.Text;
                pac.Nombre = txtNombre.Text;
                pac.Paterno = txtPaterno.Text;
                pac.Materno = txtMaterno.Text;
                pac.Fecha_Nac = dtpFechaNac.Text;
                
                //El trigger respectivo se encarga de actualizar la edad automáticamente
                pac.Edad = "0";
                
                pac.Sexo = cmbSexo.Text;
                pac.Direccion = txtDireccion.Text;
                pac.Guardar_Registros();

                sec.Nro_familiar_Contacto = txtNumTel.Text;
                sec.Formulario_Referencia = chkFormularioRef.Checked;
                sec.Carta_Negativa = chkCartNeg.Checked;
                sec.Grado_Intruccion = txtGradInstr.Text;
                sec.Red= txtRed.Text;
                sec.Municipio = txtMunicipio.Text;
                sec.Seguro = cmbSeguro.Text;
                sec.Fecha_PHemodialisis = dtpPrimHem.Text;
                sec.CI1 = txtCi.Text;
                sec.Id_empleado = Constantes.ID_Emp;
                sec.Guardar_Registros();
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
            txtNombre.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            dtpFechaNac.ResetText();
            cmbSexo.ResetText();
            txtDireccion.Clear();
            txtCi.Clear();
            txtNumTel.Clear();
            txtGradInstr.Clear();
            txtRed.Clear();
            txtMunicipio.Clear();
            cmbSeguro.ResetText();
            txtParam.Clear();
            dtpPrimHem.ResetText();            
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            if (rdbName.Checked == true)
            {

            }
            DataSet ds = new DataSet();
            ds = sec.Buscar_Registros(txtParam.Text);
            dgvHojaRegistro.DataSource = ds;
            dgvHojaRegistro.DataMember = "tac";
            dgvHojaRegistro.AutoResizeColumns();
            dgvHojaRegistro.AutoResizeRows();
        }
        
        private void txtNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void txtCi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void txtGradInstr_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
