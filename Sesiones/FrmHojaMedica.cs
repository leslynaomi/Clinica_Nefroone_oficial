﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class FrmHojaMedica : Form
    {
        public FrmHojaMedica()
        {
            InitializeComponent();
        }

        private void btnMenuPacientes_Click(object sender, EventArgs e)
        {
            FrmGestionarPaciente frm = new FrmGestionarPaciente();
            frm.Show();
        }
    }
}