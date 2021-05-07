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
    public partial class frmRecetario : Form
    {
        public frmRecetario()
        {
            InitializeComponent();

        }

        clsRecetario Rec = new clsRecetario();
        clsDetalleReceta Detalle = new clsDetalleReceta();

        string recolector_id = "";
        private void LimpiarTexto()
        {

            txtFecha.ResetText();

            txtCantidad.Clear();
            txtPaciente.Clear();

        }

        private void Limpiarrad()
        {
            rbCateter.Checked = false;
            rbFistula.Checked = false;
            rbPeritoneal.Checked = false;

        }
        private void seguirlista()
        {

            txtCantidad.Clear();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string tipo = "C";
            if (rbFistula.Checked == true)
            {
                dgvMedicamento.DataSource = Rec.Mostrar_RegistrosT(tipo);
                dgvMedicamento.DataMember = "tac";

                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();

            }

            if (rbFistula.Checked == false) { }

        }

        private void frmRecetario_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string tipo = "F";
            if (rbFistula.Checked == true)
            {
                dgvMedicamento.DataSource = Rec.Mostrar_RegistrosT(tipo);
                dgvMedicamento.DataMember = "tac";

                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();

            }

            if (rbFistula.Checked == false) { }
        }

        private void rbPeritoneal_CheckedChanged(object sender, EventArgs e)
        {
            string tipo = "P";
            if (rbFistula.Checked == true)
            {
                dgvMedicamento.DataSource = Rec.Mostrar_RegistrosT(tipo);
                dgvMedicamento.DataMember = "tac";

                dgvMedicamento.AutoResizeColumns();
                dgvMedicamento.AutoResizeRows();

            }

            if (rbFistula.Checked == false) { }

        }






        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos met = new Metodos();
                ///registros de detalle receta
                ///
                DataTable Re = new DataTable();
                Detalle.Id_medicamento = recolector_id;
                Re = Rec.idReceta(txtPaciente.Text, txtFecha.Text).Tables[0];
                string recolR = met.DatatableToString(Re);
                Detalle.Id_receta = recolR;
                Detalle.Cant_recetada = txtCantidad.Text;



                seguirlista();

                DataSet ds = new DataSet();
                ds = Rec.Mostrar_Registros(txtFecha.Text, txtPaciente.Text);
                dgvreceta.DataSource = ds;
                dgvreceta.DataMember = "tac";
                dgvreceta.AutoResizeColumns();
                dgvreceta.AutoResizeRows();


                ///  recolectorid = "";
                ///

                MessageBox.Show("Insertado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());
            }
        }

        private void dgvMedicamento_MouseClick(object sender, MouseEventArgs e)
        {
            recolector_id = dgvMedicamento.CurrentRow.Cells[1].Value.ToString();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmConsultarPacientes frm = new FrmConsultarPacientes();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Metodos met = new Metodos();


            Rec.Fecha = txtFecha.Text;
            Rec.Ci = txtPaciente.Text;
            Rec.Id_Empleado = Constantes.ID_Emp;
            DataTable dt = new DataTable();

            dt = Rec.idEvolucion(txtPaciente.Text, txtFecha.Text).Tables[0];
            string recolE = met.DatatableToString(dt);
            Rec.Id_Evolucion = recolE;


            Rec.Guardar_Registros();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
            Limpiarrad();
            dgvMedicamento.DataSource = null;
            dgvreceta.DataSource = null;
        }
    }
}
