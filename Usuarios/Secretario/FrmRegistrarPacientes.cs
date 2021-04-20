using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_negocio;

namespace capa_presentacion
{
    public partial class FrmRegistrarPacientes : Form
    {
        public FrmRegistrarPacientes()   
        {
            InitializeComponent();
        }

        //Instanciando la clase Paciente
        ClsPaciente pac = new ClsPaciente();

        private void LimpiarTexto()
        {
            txtNombre.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtFechaNac.Clear();
            txtEdad.Clear();
            txtSexo.Clear();
            txtDireccion.Clear();
        }

        private void FrmGestionarPaciente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarRegistros_Click(object sender, EventArgs e)
        {
            dgvPaciente.DataSource = pac.Mostrar_Registros();
            dgvPaciente.DataMember = "tac";
            dgvPaciente.AutoResizeColumns();
            dgvPaciente.AutoResizeRows();
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                pac.Ci = txtCi.Text;
                pac.Nombre = txtNombre.Text;
                pac.Paterno = txtPaterno.Text;
                pac.Materno = txtMaterno.Text;
                pac.Fecha_Nac = txtFechaNac.Text;
                pac.Edad = txtEdad.Text;
                pac.Sexo = txtSexo.Text;
                pac.Direccion = txtDireccion.Text;
                pac.Guardar_Registros();
                LimpiarTexto();
                MessageBox.Show("Insertado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }            
        }

        private void btnModificarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCi.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de CI de paciente para proceder");
                }
                else
                {
                    pac.Ci = txtCi.Text;
                    pac.Nombre = txtNombre.Text;
                    pac.Paterno = txtPaterno.Text;
                    pac.Materno = txtMaterno.Text;
                    pac.Fecha_Nac = txtFechaNac.Text;
                    pac.Edad = txtEdad.Text;
                    pac.Sexo = txtSexo.Text;
                    pac.Direccion = txtDireccion.Text;
                    pac.Modificar_Registros();
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
                if (txtCi.Text == "")
                {
                    MessageBox.Show("Debe colocar un valor de CI de paciente para proceder");
                }
                else
                {
                    pac.Ci = txtCi.Text;
                    pac.Eliminar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Eliminado correctamente", "INFORMACION");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al eliminar" + er.ToString());
            }
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
           /* DataSet ds = new DataSet();
            ds = pac.Buscar_Registros(txtParam.Text);
            dgvPaciente.DataSource = ds;
            dgvPaciente.DataMember = "tac";
            dgvPaciente.AutoResizeColumns();
            dgvPaciente.AutoResizeRows();*/
        }

        private void FrmRegistrarPacientes_Load(object sender, EventArgs e)
        {
            dgvPaciente.DataSource = pac.Mostrar_Registros();
            dgvPaciente.DataMember = "tac";
            dgvPaciente.AutoResizeColumns();
            dgvPaciente.AutoResizeRows();
        }
    }
}
