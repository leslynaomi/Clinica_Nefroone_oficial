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
namespace capa_presentacion.Usuarios.Farmaceutico
{
    public partial class frmRecetario : Form
    {
        private bool unChecedkAll = false;
        public frmRecetario()
        {
            InitializeComponent();
        }
        clsRecetario Rec= new clsRecetario();



     //*//  public void ExportarDatos(DataGridView datalistado)
      //  {
        ///    Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();
        ///    exportar.Application.Workbooks.Add(true);
       //     int indice = 0;
      //      foreach(DataGridViewColumn column in datalistado.Columns)
        //    {
       ///         indice++;
        ///        exportar.Cells[1, indice] = Columns.Name;

      ///      }
    //*///
       /// }
       /// 




        private void limpiarbtn() {
            rbCateter.Checked = false;
            rbFistula.Checked = false;
            rbPeritoneal.Checked = false;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCateter.Checked == true)
            {
                dgvMedicamento.DataSource = Rec.Mostrar_RegistrosC();

                dgvMedicamento.DataMember = "tac";
                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();
              
            
            }
           
        }

        private void frmRecetario_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFistula.Checked == true)
            {
                dgvMedicamento.DataSource = Rec.Mostrar_RegistrosF();
                dgvMedicamento.DataMember = "tac";
             
                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();
             
            }
      
        }

        private void rbPeritoneal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeritoneal.Checked == true)
            {
                dgvMedicamento.DataSource = Rec.Mostrar_RegistrosP();
                dgvMedicamento.DataMember = "tac";
                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();
                
            }
        
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in dgvMedicamento.Rows) {
            
                if((bool)item.Cells[0].Value==true) {

                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();

                    

                }

            }
        }

        private void dgvMedicamento_MouseClick(object sender, MouseEventArgs e)
        {  
           
        }
    }
}
