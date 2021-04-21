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
    public partial class FrmDialisisPeritoneal : Form
    {
        public FrmDialisisPeritoneal()
        {
            InitializeComponent();
        }
        ClassDialisisPeritonea dp = new ClassDialisisPeritonea();


        private void LimpiarTexto()
        {//hola pooooool

            TimeInfucionesInicio.ResetText();
            TimeInfucionesFin.ResetText();
            T;
            txtInfusionesVolumen.Clear();
            text1inicio.Clear();
            txtDrenajeVolumen.Clear();
            txtBalanceParcial.Clear();
            txtBalanceTotal.Clear();
            textsolucionusada1.Clear();
            textsolucionusada2.Clear();
            textobservaciones.Clear();
            texthojaenfermeria.Clear();
            textsesion1.Clear();
        }
        private void binsertar_Click(object sender, EventArgs e)
        {
            try
            {

                
                dp.Ainfucion_Inicio = TimeInfucionesInicio.Text;
                dp.Ainfucion_Final = textfin.Text;
                dp.Ainfucion_Volumen = txtInfusionesVolumen.Text;
                dp.Adrenaje_Inicio = text1inicio.Text;
                dp.Adrenaje_Volumen = txtDrenajeVolumen.Text;
                dp.Abalance_Parcial = txtBalanceParcial.Text;
                dp.Abalance_Total = txtBalanceTotal.Text;
                dp.Asolucion_Usada1 = textsolucionusada1.Text;
                dp.Asolucion_Usada2 = textsolucionusada2.Text;
                dp.Aobservacion_Balance = textobservaciones.Text;
                dp.Aid_hoja_enfermeria = texthojaenfermeria.Text;
                dp.Aid_sesion = textsesion1.Text;

                dp.Guardar_Registros();
                LimpiarTexto();
                MessageBox.Show("Insertado correctamente", "INFORMACION");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al insertar" + er.ToString());

            }

            }

        

        private void FrmDialisisPeritoneal_Load(object sender, EventArgs e)
        {
             dda.DataSource = dp.Mostrar_Registros();
            dda.DataMember = "tac";
            dda.AutoResizeColumns();
            dda.AutoResizeRows();
        }

        private void bmostrar_Click(object sender, EventArgs e)
        {

            //try
            //{
            //  if (textsesion1.Text == "" || texthojaenfermeria.Text == "" )
            //{
            //  MessageBox.Show("Debe colocar un valor de Nº de hoja registro, una ID de la Hoja de Control de Enfermería y un ID de empleado para poder proceder");
            //}
            //else
            //{
            //  dp.Aprecio_Sesion_D_Peritoneal = textprecio_total.Text;
            //dp.Ainfucion_Inicio = textinicio.Text;
            //dp.Ainfucion_Final = textfin.Text;
            //dp.Ainfucion_Volumen = textvolumen.Text;
            //dp.Adrenaje_Inicio = text1inicio.Text;
            //dp.Adrenaje_Volumen = text1volumen.Text;
            //dp.Abalance_Parcial = textparcial.Text;
            //dp.Abalance_Total = texttotal.Text;
            //dp.Asolucion_Usada1 = textsolucionusada1.Text;
            //dp.Asolucion_Usada2 = textsolucionusada2.Text;
            //dp.Aobservacion_Balance = textobservaciones.Text;
            //dp.Aid_hoja_enfermeria = texthojaenfermeria.Text;
            //dp.Aid_sesion = textsesion1.Text;

            //LimpiarTexto();
            //MessageBox.Show("Modificado correctamente", "INFORMACION");
            //}
            //}
            //catch (Exception er)
            //{
            //   MessageBox.Show("Error al modificar" + er.ToString());
            //}
            dda.DataSource = dp.Mostrar_Registros();
            dda.DataMember = "tac";
            dda.AutoResizeColumns();
            dda.AutoResizeRows();
        }

        private void bhojaenfermeria_Click(object sender, EventArgs e)
        {

            FrmHojaEnfermeria frm = new FrmHojaEnfermeria();
            frm.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
