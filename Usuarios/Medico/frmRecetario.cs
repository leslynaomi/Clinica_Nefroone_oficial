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

namespace capa_presentacion.Usuarios.Medico
{
    public partial class frmRecetario : Form
    {
        public frmRecetario()
        {
            InitializeComponent();
        }
        clsRecetario ins = new clsRecetario();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true) {
                dgvInsumos.DataSource = ins.Mostrar_RegistrosF();
                dgvInsumos.DataMember = "tac";
                dgvInsumos.AutoResizeColumns();
                dgvInsumos.AutoResizeRows();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                dgvInsumos.DataSource = ins.Mostrar_RegistrosC();
                dgvInsumos.DataMember = "tac";
                dgvInsumos.AutoResizeColumns();
                dgvInsumos.AutoResizeRows();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                dgvInsumos.DataSource = ins.Mostrar_RegistrosP();
                dgvInsumos.DataMember = "tac";
                dgvInsumos.AutoResizeColumns();
                dgvInsumos.AutoResizeRows();
            }
        }
    }
}
