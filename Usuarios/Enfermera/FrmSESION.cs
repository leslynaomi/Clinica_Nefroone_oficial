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

using capa_datos;

namespace capa_presentacion

{
    public partial class FrmSESION : Form
    {
        public FrmSESION()
        {
            InitializeComponent();
        }

        ClassSESION sesi = new ClassSESION();



        private void LimpiarTexto()
        {//hola
            textpesoinicial.Clear();
            textpesofinal.Clear();
            textidsesion.Clear();
            textidempleado.Clear();
            textidnota.Clear();
            textidhojas.Clear();



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = sesi.Buscar_Registros(txtbuscar.Text);
            data.DataSource = ds;
            data.DataMember = "tac";
            data.AutoResizeColumns();
            data.AutoResizeRows();
        }

        private void txtinsertar_Click(object sender, EventArgs e)
        {
            {
                try
                {


                    sesi.Afecha_sesion = datesesion.Text;
                    sesi.Apeso_final = textpesofinal.Text;
                    sesi.Apeso_inicial = textpesoinicial.Text;
                    sesi.Aid_sesion = textidsesion.Text;
                    sesi.Aid_empleado = textidempleado.Text;
                    sesi.Aid_nota= textidnota.Text;
                    sesi.Aid_hojaS = textidhojas.Text;

                    sesi.Guardar_Registros();
                    LimpiarTexto();
                    MessageBox.Show("Insertado correctamente", "INFORMACION");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al insertar" + er.ToString());

                }

            }
        }

        private void txtmostrar_Click(object sender, EventArgs e)
        {
            data.DataSource = sesi.Mostrar_Registros();
            data.DataMember = "tac";
            data.AutoResizeColumns();
            data.AutoResizeRows();
        }
    }
}
