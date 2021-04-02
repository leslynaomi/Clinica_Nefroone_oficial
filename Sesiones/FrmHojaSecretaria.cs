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
        }

        ClsHojaRegistro reg = new ClsHojaRegistro();

        private void btnMenuPacientes_Click(object sender, EventArgs e)
        {
            FrmGestionarPaciente frm = new FrmGestionarPaciente();
            frm.Show();
        }

        private void FrmHojaSecretaria_Load(object sender, EventArgs e)
        {
            dgvHojaRegistro.DataSource = reg.Mostrar_Registros();
            dgvHojaRegistro.DataMember = "tac";
            dgvHojaRegistro.AutoResizeColumns();
            dgvHojaRegistro.AutoResizeRows();
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvHojaRegistro.DataSource = reg.Mostrar_Registros();
            dgvHojaRegistro.DataMember = "tac";
            dgvHojaRegistro.AutoResizeColumns();
            dgvHojaRegistro.AutoResizeRows();
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                reg.Nro_familiar_Contacto = txtNumTel.Text;
                reg.Formulario_Referencia = chkFormularioRef.Checked;
                reg.Carta_Negativa = txtCartNeg.Text;
                reg.Grado_Intruccion = txtGradoInst.Text;
                reg.Red= txtRed.Text;
                reg.Municipio = txtMunicipio.Text;
                reg.Seguro = txtSeguro.Text;
                reg.Fecha_PHemodialisis = dtpPrimHem.Text;
                reg.CI1 = txtCi.Text;
                reg.Guardar_Registros();
                LimpiarTexto();
                MessageBox.Show("Insertado correctamente", "INFORMACION");
                reg = new ClsHojaRegistro();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }

        private void LimpiarTexto()
        {
            txtCi.Clear();
            txtNumTel.Clear();
            txtCartNeg.Clear();
            txtGradoInst.Clear();
            txtRed.Clear();
            txtMunicipio.Clear();
            txtSeguro.Clear();
            txtNroReg.Clear();
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = reg.Buscar_Registros(txtParam.Text);
            dgvHojaRegistro.DataSource = ds;
            dgvHojaRegistro.DataMember = "tac";
            dgvHojaRegistro.AutoResizeColumns();
            dgvHojaRegistro.AutoResizeRows();
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNroReg.Text == "" || txtCi.Text == "")
                { 
                    MessageBox.Show("Debe colocar un valor de Nº de hoja registro y de CI");
                }
                else 
                {
                    reg.Nro_registro = txtNroReg.Text;
                    reg.Nro_familiar_Contacto = txtNumTel.Text;
                    reg.Formulario_Referencia = chkFormularioRef.Checked;
                    reg.Carta_Negativa = txtCartNeg.Text;
                    reg.Grado_Intruccion = txtGradoInst.Text;
                    reg.Red = txtRed.Text;
                    reg.Municipio = txtMunicipio.Text;
                    reg.Seguro = txtSeguro.Text;
                    reg.Fecha_PHemodialisis = dtpPrimHem.Text;
                    reg.CI1 = txtCi.Text;
                    reg.Modificar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Registros modificados correctamente", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNroReg.Text == "" || txtCi.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de Nº de hoja registro y de CI");
                }
                else
                {
                    reg.Nro_registro = txtNroReg.Text;                   
                    reg.CI1 = txtCi.Text;
                    reg.Eliminar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Registros modificados correctamente", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }
    }
}
