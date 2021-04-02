using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Nefroone
{
    public partial class FrmRegistrarPersonalNuevo : Form
    {
        public FrmRegistrarPersonalNuevo()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void FrmRegistrarPersonalNuevo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.Enfermera' Puede moverla o quitarla según sea necesario.
            //this.enfermeraTableAdapter.Fill(this.clinicaDataSet.Enfermera);
            // TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            //this.empleadoTableAdapter.Fill(this.clinicaDataSet.Empleado);

        }
    }
}
