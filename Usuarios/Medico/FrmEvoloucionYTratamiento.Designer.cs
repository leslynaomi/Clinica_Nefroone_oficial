
namespace capa_presentacion
{
    partial class FrmEvoloucionYTratamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtParamBusc = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.txtFlujoDial = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvHojaEvolucionTrat = new System.Windows.Forms.DataGridView();
            this.txtUltraFil = new System.Windows.Forms.TextBox();
            this.txtNroUsoFiltro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDuracion = new System.Windows.Forms.ComboBox();
            this.rtbEvolClin = new System.Windows.Forms.RichTextBox();
            this.txtSolDial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrupoSang = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtSerologia = new System.Windows.Forms.TextBox();
            this.txtPesoSeco = new System.Windows.Forms.TextBox();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.chkVIH = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rdbEdad = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbCi = new System.Windows.Forms.RadioButton();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEvolucionTrat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParamBusc
            // 
            this.txtParamBusc.Location = new System.Drawing.Point(460, 65);
            this.txtParamBusc.Name = "txtParamBusc";
            this.txtParamBusc.Size = new System.Drawing.Size(131, 20);
            this.txtParamBusc.TabIndex = 157;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(311, 60);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(131, 29);
            this.btnBuscarRegistros.TabIndex = 156;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(30, 56);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(211, 29);
            this.btnMostrarRegistros.TabIndex = 155;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click);
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(30, 605);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(211, 29);
            this.btnInsertarRegistros.TabIndex = 154;
            this.btnInsertarRegistros.Text = "Insertar Registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // txtFlujoDial
            // 
            this.txtFlujoDial.Location = new System.Drawing.Point(141, 162);
            this.txtFlujoDial.Name = "txtFlujoDial";
            this.txtFlujoDial.Size = new System.Drawing.Size(100, 20);
            this.txtFlujoDial.TabIndex = 145;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 143;
            this.label15.Text = "Evolución clínica";
            // 
            // dgvHojaEvolucionTrat
            // 
            this.dgvHojaEvolucionTrat.AllowUserToOrderColumns = true;
            this.dgvHojaEvolucionTrat.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvHojaEvolucionTrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaEvolucionTrat.Location = new System.Drawing.Point(264, 100);
            this.dgvHojaEvolucionTrat.Name = "dgvHojaEvolucionTrat";
            this.dgvHojaEvolucionTrat.Size = new System.Drawing.Size(792, 531);
            this.dgvHojaEvolucionTrat.TabIndex = 138;
            // 
            // txtUltraFil
            // 
            this.txtUltraFil.Location = new System.Drawing.Point(141, 100);
            this.txtUltraFil.Name = "txtUltraFil";
            this.txtUltraFil.Size = new System.Drawing.Size(100, 20);
            this.txtUltraFil.TabIndex = 132;
            // 
            // txtNroUsoFiltro
            // 
            this.txtNroUsoFiltro.Location = new System.Drawing.Point(141, 195);
            this.txtNroUsoFiltro.Name = "txtNroUsoFiltro";
            this.txtNroUsoFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtNroUsoFiltro.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 127;
            this.label6.Text = "Flujo diálisis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 126;
            this.label5.Text = "Duración";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 125;
            this.label3.Text = "Nº de Uso Filtro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 123;
            this.label11.Text = "Ultra filtración";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "Evolución y Tratamiento";
            // 
            // cbxDuracion
            // 
            this.cbxDuracion.FormattingEnabled = true;
            this.cbxDuracion.Items.AddRange(new object[] {
            "1 hora",
            "2 horas",
            "3 horas",
            "4 horas",
            "5 horas"});
            this.cbxDuracion.Location = new System.Drawing.Point(141, 130);
            this.cbxDuracion.Name = "cbxDuracion";
            this.cbxDuracion.Size = new System.Drawing.Size(100, 21);
            this.cbxDuracion.TabIndex = 166;
            // 
            // rtbEvolClin
            // 
            this.rtbEvolClin.Location = new System.Drawing.Point(30, 476);
            this.rtbEvolClin.Name = "rtbEvolClin";
            this.rtbEvolClin.Size = new System.Drawing.Size(211, 121);
            this.rtbEvolClin.TabIndex = 167;
            this.rtbEvolClin.Text = "";
            // 
            // txtSolDial
            // 
            this.txtSolDial.Location = new System.Drawing.Point(141, 409);
            this.txtSolDial.Name = "txtSolDial";
            this.txtSolDial.Size = new System.Drawing.Size(100, 20);
            this.txtSolDial.TabIndex = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 183;
            this.label4.Text = "Solución dializante";
            // 
            // txtGrupoSang
            // 
            this.txtGrupoSang.Location = new System.Drawing.Point(141, 379);
            this.txtGrupoSang.Name = "txtGrupoSang";
            this.txtGrupoSang.Size = new System.Drawing.Size(100, 20);
            this.txtGrupoSang.TabIndex = 182;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(141, 317);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(100, 20);
            this.txtIMC.TabIndex = 181;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(141, 347);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(100, 20);
            this.txtTalla.TabIndex = 180;
            // 
            // txtSerologia
            // 
            this.txtSerologia.Location = new System.Drawing.Point(141, 287);
            this.txtSerologia.Name = "txtSerologia";
            this.txtSerologia.Size = new System.Drawing.Size(100, 20);
            this.txtSerologia.TabIndex = 178;
            // 
            // txtPesoSeco
            // 
            this.txtPesoSeco.Location = new System.Drawing.Point(141, 257);
            this.txtPesoSeco.Name = "txtPesoSeco";
            this.txtPesoSeco.Size = new System.Drawing.Size(100, 20);
            this.txtPesoSeco.TabIndex = 177;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(141, 226);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(100, 20);
            this.txtDiagnostic.TabIndex = 176;
            // 
            // chkVIH
            // 
            this.chkVIH.AutoSize = true;
            this.chkVIH.Location = new System.Drawing.Point(164, 447);
            this.chkVIH.Name = "chkVIH";
            this.chkVIH.Size = new System.Drawing.Size(44, 17);
            this.chkVIH.TabIndex = 175;
            this.chkVIH.Text = "VIH";
            this.chkVIH.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 174;
            this.label9.Text = "Grupo sanguíneo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 173;
            this.label10.Text = "Talla";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 171;
            this.label13.Text = "Serología";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 170;
            this.label14.Text = "Peso seco";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 26);
            this.label16.TabIndex = 169;
            this.label16.Text = "Índice de masa\r\ncorporal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 168;
            this.label17.Text = "Diagnóstico";
            // 
            // rdbEdad
            // 
            this.rdbEdad.AutoSize = true;
            this.rdbEdad.Location = new System.Drawing.Point(1005, 66);
            this.rdbEdad.Name = "rdbEdad";
            this.rdbEdad.Size = new System.Drawing.Size(50, 17);
            this.rdbEdad.TabIndex = 188;
            this.rdbEdad.TabStop = true;
            this.rdbEdad.Text = "Edad";
            this.rdbEdad.UseVisualStyleBackColor = true;
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(775, 66);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(62, 17);
            this.rdbApellido.TabIndex = 186;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            // 
            // rdbCi
            // 
            this.rdbCi.AutoSize = true;
            this.rdbCi.Location = new System.Drawing.Point(865, 66);
            this.rdbCi.Name = "rdbCi";
            this.rdbCi.Size = new System.Drawing.Size(118, 17);
            this.rdbCi.TabIndex = 187;
            this.rdbCi.TabStop = true;
            this.rdbCi.Text = "Carnet de Identidad";
            this.rdbCi.UseVisualStyleBackColor = true;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(694, 66);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(62, 17);
            this.rdbName.TabIndex = 185;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Nombre";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 189;
            this.label2.Text = "Buscar por:";
            // 
            // FrmEvoloucionYTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1081, 652);
            this.Controls.Add(this.rdbEdad);
            this.Controls.Add(this.rdbApellido);
            this.Controls.Add(this.rdbCi);
            this.Controls.Add(this.rdbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSolDial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrupoSang);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtSerologia);
            this.Controls.Add(this.txtPesoSeco);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.chkVIH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rtbEvolClin);
            this.Controls.Add(this.cbxDuracion);
            this.Controls.Add(this.txtParamBusc);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.txtFlujoDial);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvHojaEvolucionTrat);
            this.Controls.Add(this.txtUltraFil);
            this.Controls.Add(this.txtNroUsoFiltro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "FrmEvoloucionYTratamiento";
            this.Text = "frmEvoloucionYTratamiento";
            this.Load += new System.EventHandler(this.frmEvoloucionYTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEvolucionTrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtParamBusc;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.TextBox txtFlujoDial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvHojaEvolucionTrat;
        private System.Windows.Forms.TextBox txtUltraFil;
        private System.Windows.Forms.TextBox txtNroUsoFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDuracion;
        private System.Windows.Forms.RichTextBox rtbEvolClin;
        private System.Windows.Forms.TextBox txtSolDial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrupoSang;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtSerologia;
        private System.Windows.Forms.TextBox txtPesoSeco;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.CheckBox chkVIH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rdbEdad;
        private System.Windows.Forms.RadioButton rdbApellido;
        private System.Windows.Forms.RadioButton rdbCi;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.Label label2;
    }
}