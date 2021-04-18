using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion.Usuarios.Farmaceutico
{
    public partial class frmCola : Form
    {
        Cola C = new Cola();
        public frmCola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C.ingresaNodo(entrada.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salida.Text = C.MostrarNodo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.eliminarNodo();
            salida.Text = C.MostrarNodo();
        }
    }
}
