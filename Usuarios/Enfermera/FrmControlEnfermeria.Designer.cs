
namespace capa_presentacion
{
    partial class FrmHojaEnfermeria
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
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSesion = new System.Windows.Forms.DateTimePicker();
            this.txtPresionArt = new System.Windows.Forms.TextBox();
            this.txtFlujoEfect = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHeparina = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumSesion = new System.Windows.Forms.TextBox();
            this.dgvHojaEnfermeria = new System.Windows.Forms.DataGridView();
            this.txtSaturacion = new System.Windows.Forms.TextBox();
            this.txtUFProg = new System.Windows.Forms.TextBox();
            this.txtPulso = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPesoIni = new System.Windows.Forms.TextBox();
            this.txtPesoFin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectHojaSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEnfermeria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(52, 72);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(219, 29);
            this.btnMostrarRegistros.TabIndex = 1;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click_1);
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(52, 567);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(106, 29);
            this.btnInsertarRegistros.TabIndex = 17;
            this.btnInsertarRegistros.Text = "Insertar Registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(163, 225);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(51, 20);
            this.dtpHoraSalida.TabIndex = 7;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(163, 190);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(51, 20);
            this.dtpHoraInicio.TabIndex = 6;
            // 
            // dtpFechaSesion
            // 
            this.dtpFechaSesion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSesion.Location = new System.Drawing.Point(163, 120);
            this.dtpFechaSesion.Name = "dtpFechaSesion";
            this.dtpFechaSesion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaSesion.TabIndex = 4;
            // 
            // txtPresionArt
            // 
            this.txtPresionArt.Location = new System.Drawing.Point(163, 435);
            this.txtPresionArt.Name = "txtPresionArt";
            this.txtPresionArt.Size = new System.Drawing.Size(100, 20);
            this.txtPresionArt.TabIndex = 13;
            // 
            // txtFlujoEfect
            // 
            this.txtFlujoEfect.Location = new System.Drawing.Point(163, 400);
            this.txtFlujoEfect.Name = "txtFlujoEfect";
            this.txtFlujoEfect.Size = new System.Drawing.Size(100, 20);
            this.txtFlujoEfect.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 435);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 181;
            this.label16.Text = "Presión arterial";
            // 
            // txtHeparina
            // 
            this.txtHeparina.Location = new System.Drawing.Point(163, 365);
            this.txtHeparina.Name = "txtHeparina";
            this.txtHeparina.Size = new System.Drawing.Size(100, 20);
            this.txtHeparina.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 400);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 180;
            this.label15.Text = "Flujo efectivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 179;
            this.label2.Text = "Heparina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 178;
            this.label9.Text = "Nº de sesión";
            // 
            // txtNumSesion
            // 
            this.txtNumSesion.Location = new System.Drawing.Point(163, 155);
            this.txtNumSesion.Name = "txtNumSesion";
            this.txtNumSesion.Size = new System.Drawing.Size(100, 20);
            this.txtNumSesion.TabIndex = 5;
            // 
            // dgvHojaEnfermeria
            // 
            this.dgvHojaEnfermeria.AllowUserToOrderColumns = true;
            this.dgvHojaEnfermeria.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvHojaEnfermeria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaEnfermeria.Location = new System.Drawing.Point(289, 72);
            this.dgvHojaEnfermeria.Name = "dgvHojaEnfermeria";
            this.dgvHojaEnfermeria.Size = new System.Drawing.Size(749, 534);
            this.dgvHojaEnfermeria.TabIndex = 176;
            // 
            // txtSaturacion
            // 
            this.txtSaturacion.Location = new System.Drawing.Point(163, 540);
            this.txtSaturacion.Name = "txtSaturacion";
            this.txtSaturacion.Size = new System.Drawing.Size(100, 20);
            this.txtSaturacion.TabIndex = 16;
            // 
            // txtUFProg
            // 
            this.txtUFProg.Location = new System.Drawing.Point(163, 330);
            this.txtUFProg.Name = "txtUFProg";
            this.txtUFProg.Size = new System.Drawing.Size(100, 20);
            this.txtUFProg.TabIndex = 10;
            // 
            // txtPulso
            // 
            this.txtPulso.Location = new System.Drawing.Point(163, 505);
            this.txtPulso.Name = "txtPulso";
            this.txtPulso.Size = new System.Drawing.Size(100, 20);
            this.txtPulso.TabIndex = 15;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(163, 470);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 14;
            // 
            // txtPesoIni
            // 
            this.txtPesoIni.Location = new System.Drawing.Point(163, 260);
            this.txtPesoIni.Name = "txtPesoIni";
            this.txtPesoIni.Size = new System.Drawing.Size(100, 20);
            this.txtPesoIni.TabIndex = 8;
            // 
            // txtPesoFin
            // 
            this.txtPesoFin.Location = new System.Drawing.Point(163, 295);
            this.txtPesoFin.Name = "txtPesoFin";
            this.txtPesoFin.Size = new System.Drawing.Size(100, 20);
            this.txtPesoFin.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 540);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 169;
            this.label13.Text = "Saturación";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 167;
            this.label12.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 168;
            this.label8.Text = "UF Programada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 166;
            this.label7.Text = "Peso final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 165;
            this.label6.Text = "Hora salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 162;
            this.label4.Text = "Pulso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 164;
            this.label5.Text = "Hora inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 163;
            this.label3.Text = "Peso inicial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 161;
            this.label11.Text = "Fecha de sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 160;
            this.label1.Text = "Control de Enfermería";
            // 
            // btnSelectHojaSec
            // 
            this.btnSelectHojaSec.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSelectHojaSec.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelectHojaSec.Location = new System.Drawing.Point(164, 567);
            this.btnSelectHojaSec.Name = "btnSelectHojaSec";
            this.btnSelectHojaSec.Size = new System.Drawing.Size(119, 29);
            this.btnSelectHojaSec.TabIndex = 182;
            this.btnSelectHojaSec.Text = "Seleccionar Paciente";
            this.btnSelectHojaSec.UseVisualStyleBackColor = false;
            this.btnSelectHojaSec.Click += new System.EventHandler(this.btnSelectHojaSec_Click);
            // 
            // FrmHojaEnfermeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1081, 652);
            this.Controls.Add(this.btnSelectHojaSec);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFechaSesion);
            this.Controls.Add(this.txtPresionArt);
            this.Controls.Add(this.txtFlujoEfect);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtHeparina);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumSesion);
            this.Controls.Add(this.dgvHojaEnfermeria);
            this.Controls.Add(this.txtSaturacion);
            this.Controls.Add(this.txtUFProg);
            this.Controls.Add(this.txtPulso);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtPesoIni);
            this.Controls.Add(this.txtPesoFin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "FrmHojaEnfermeria";
            this.Text = "FrmHojaEnfermeria";
            this.Load += new System.EventHandler(this.FrmHojaEnfermeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEnfermeria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaSesion;
        private System.Windows.Forms.TextBox txtPresionArt;
        private System.Windows.Forms.TextBox txtFlujoEfect;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHeparina;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumSesion;
        private System.Windows.Forms.DataGridView dgvHojaEnfermeria;
        private System.Windows.Forms.TextBox txtSaturacion;
        private System.Windows.Forms.TextBox txtUFProg;
        private System.Windows.Forms.TextBox txtPulso;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPesoIni;
        private System.Windows.Forms.TextBox txtPesoFin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectHojaSec;
    }
}