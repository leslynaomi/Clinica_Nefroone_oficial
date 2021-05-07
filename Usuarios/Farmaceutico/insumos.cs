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
    public partial class insumos : Form
    {

        public insumos()
        {
            InitializeComponent();
        }
        
        clsInsumos ins = new clsInsumos();

        private void LimpiarTexto()
        {
            textNameMedic.Clear();
            textPresentacion.Clear();
            textConcentracion.Clear();
            textStock.Clear();
            textDiagnostico.Clear();

        }

        private void insumos_Load(object sender, EventArgs e)
        {
            dgvMedicamento.DataSource = ins.Mostrar_Registros();
            dgvMedicamento.DataMember = "tac";
            dgvMedicamento.AutoResizeColumns();
            dgvMedicamento.AutoResizeRows();
        }

        private void dgvMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textNameMedic.Text = dgvMedicamento.CurrentRow.Cells[1].Value.ToString();
                textPresentacion.Text = dgvMedicamento.CurrentRow.Cells[2].Value.ToString();
                textConcentracion.Text = dgvMedicamento.CurrentRow.Cells[3].Value.ToString();
                textStock.Text = dgvMedicamento.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnInsertarRegistros_Click_1(object sender, EventArgs e)
        {
            try
            {
                ins.Nombre_medicamento = textNameMedic.Text;
                ins.Presentacion = textPresentacion.Text;
                ins.Concentracion = textConcentracion.Text;
                ins.Stock = textStock.Text;

                ////prueba
                dgvMedicamento.DataSource = ins.Mostrar_Registros();
                dgvMedicamento.DataMember = "tac";
                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();
                ////
                LimpiarTexto();
                MessageBox.Show("Insertado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }
    }
}

