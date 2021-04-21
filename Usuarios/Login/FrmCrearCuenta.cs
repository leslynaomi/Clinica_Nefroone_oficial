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
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
            
            //Impedir que se pueda escribir texto en el combobox
            cbxTipoUser.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        ClsEmpleado emp = new ClsEmpleado();

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Comentado por que no permite tampoco los espacios y ellos son necesarios en múltiples
            //nombres de personas
            //Metodos.SoloLetras(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicioSesion frm = new FrmInicioSesion();
            frm.Show();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloNumeros(e);
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.SoloLetras(e);
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPassw1.Text == txtPasswd2.Text)
                {                    
                    emp.Nombre1 = txtNombre.Text;
                    emp.Paterno1 = txtPaterno.Text;
                    emp.Materno1 = txtMaterno.Text;
                    emp.Ci1 = txtCI.Text;
                    emp.Fecha_Nac1 = dtpFechaNac.Text;
                    emp.Nro_Celular1 = txtTel.Text;
                    emp.Tipo1 = cbxTipoUser.Text;
                    emp.Usuario = txtUser.Text;
                    emp.Passwd = txtPassw1.Text;
                    emp.Guardar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Cuenta creada correctamente", "INFORMACION");
                    btnCancelar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!", "INFORMACION");
                }                                                
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
            txtCI.Clear();
            dtpFechaNac.ResetText();
            txtTel.Clear();
            cbxTipoUser.ResetText();
            txtUser.Clear();
            txtPassw1.Clear();
            txtPasswd2.Clear();
        }
    }
}
