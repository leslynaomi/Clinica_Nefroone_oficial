
namespace capa_presentacion
{
    partial class FrmConsultaEvolYTrat
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
            this.rdbGrupSang = new System.Windows.Forms.RadioButton();
            this.rdbAccesoVasc = new System.Windows.Forms.RadioButton();
            this.rdbVIH = new System.Windows.Forms.RadioButton();
            this.rdbFechaSesion = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParamBusc = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.dgvHojaEvolucionTrat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.rdbNameMed = new System.Windows.Forms.RadioButton();
            this.rdbApellidoMed = new System.Windows.Forms.RadioButton();
            this.cbxAccesoV = new System.Windows.Forms.ComboBox();
            this.dtpFechaSes = new System.Windows.Forms.DateTimePicker();
            this.cbxVIH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEvolucionTrat)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbGrupSang
            // 
            this.rdbGrupSang.AutoSize = true;
            this.rdbGrupSang.Location = new System.Drawing.Point(694, 73);
            this.rdbGrupSang.Name = "rdbGrupSang";
            this.rdbGrupSang.Size = new System.Drawing.Size(108, 17);
            this.rdbGrupSang.TabIndex = 7;
            this.rdbGrupSang.TabStop = true;
            this.rdbGrupSang.Text = "Grupo sanguíneo";
            this.rdbGrupSang.UseVisualStyleBackColor = true;
            this.rdbGrupSang.CheckedChanged += new System.EventHandler(this.rdbGrupSang_CheckedChanged);
            // 
            // rdbAccesoVasc
            // 
            this.rdbAccesoVasc.AutoSize = true;
            this.rdbAccesoVasc.Location = new System.Drawing.Point(530, 74);
            this.rdbAccesoVasc.Name = "rdbAccesoVasc";
            this.rdbAccesoVasc.Size = new System.Drawing.Size(105, 17);
            this.rdbAccesoVasc.TabIndex = 5;
            this.rdbAccesoVasc.TabStop = true;
            this.rdbAccesoVasc.Text = "Acceso Vascular";
            this.rdbAccesoVasc.UseVisualStyleBackColor = true;
            this.rdbAccesoVasc.CheckedChanged += new System.EventHandler(this.rdbAccesoVasc_CheckedChanged);
            // 
            // rdbVIH
            // 
            this.rdbVIH.AutoSize = true;
            this.rdbVIH.Location = new System.Drawing.Point(645, 74);
            this.rdbVIH.Name = "rdbVIH";
            this.rdbVIH.Size = new System.Drawing.Size(43, 17);
            this.rdbVIH.TabIndex = 6;
            this.rdbVIH.TabStop = true;
            this.rdbVIH.Text = "VIH";
            this.rdbVIH.UseVisualStyleBackColor = true;
            this.rdbVIH.CheckedChanged += new System.EventHandler(this.rdbVIH_CheckedChanged);
            // 
            // rdbFechaSesion
            // 
            this.rdbFechaSesion.AutoSize = true;
            this.rdbFechaSesion.Location = new System.Drawing.Point(421, 74);
            this.rdbFechaSesion.Name = "rdbFechaSesion";
            this.rdbFechaSesion.Size = new System.Drawing.Size(103, 17);
            this.rdbFechaSesion.TabIndex = 4;
            this.rdbFechaSesion.TabStop = true;
            this.rdbFechaSesion.Text = "Fecha de sesión";
            this.rdbFechaSesion.UseVisualStyleBackColor = true;
            this.rdbFechaSesion.CheckedChanged += new System.EventHandler(this.rdbFechaSesion_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 197;
            this.label2.Text = "Buscar por:";
            // 
            // txtParamBusc
            // 
            this.txtParamBusc.Location = new System.Drawing.Point(248, 73);
            this.txtParamBusc.Name = "txtParamBusc";
            this.txtParamBusc.Size = new System.Drawing.Size(100, 20);
            this.txtParamBusc.TabIndex = 192;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(164, 68);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(78, 29);
            this.btnBuscarRegistros.TabIndex = 3;
            this.btnBuscarRegistros.Text = "Buscar";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // dgvHojaEvolucionTrat
            // 
            this.dgvHojaEvolucionTrat.AllowUserToOrderColumns = true;
            this.dgvHojaEvolucionTrat.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvHojaEvolucionTrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaEvolucionTrat.Location = new System.Drawing.Point(27, 116);
            this.dgvHojaEvolucionTrat.Name = "dgvHojaEvolucionTrat";
            this.dgvHojaEvolucionTrat.Size = new System.Drawing.Size(1027, 515);
            this.dgvHojaEvolucionTrat.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 198;
            this.label1.Text = "Evolución y Tratamiento";
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(27, 68);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(103, 29);
            this.btnMostrarRegistros.TabIndex = 1;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click);
            // 
            // rdbNameMed
            // 
            this.rdbNameMed.AutoSize = true;
            this.rdbNameMed.Location = new System.Drawing.Point(808, 74);
            this.rdbNameMed.Name = "rdbNameMed";
            this.rdbNameMed.Size = new System.Drawing.Size(114, 17);
            this.rdbNameMed.TabIndex = 8;
            this.rdbNameMed.TabStop = true;
            this.rdbNameMed.Text = "Nombre de médico";
            this.rdbNameMed.UseVisualStyleBackColor = true;
            this.rdbNameMed.CheckedChanged += new System.EventHandler(this.rdbNameMed_CheckedChanged);
            // 
            // rdbApellidoMed
            // 
            this.rdbApellidoMed.AutoSize = true;
            this.rdbApellidoMed.Location = new System.Drawing.Point(928, 74);
            this.rdbApellidoMed.Name = "rdbApellidoMed";
            this.rdbApellidoMed.Size = new System.Drawing.Size(114, 17);
            this.rdbApellidoMed.TabIndex = 9;
            this.rdbApellidoMed.TabStop = true;
            this.rdbApellidoMed.Text = "Apellido de médico";
            this.rdbApellidoMed.UseVisualStyleBackColor = true;
            this.rdbApellidoMed.CheckedChanged += new System.EventHandler(this.rdbApellidoMed_CheckedChanged);
            // 
            // cbxAccesoV
            // 
            this.cbxAccesoV.FormattingEnabled = true;
            this.cbxAccesoV.Items.AddRange(new object[] {
            "Cateter",
            "Fistula",
            "Dialisis Peritoneal"});
            this.cbxAccesoV.Location = new System.Drawing.Point(249, 72);
            this.cbxAccesoV.Name = "cbxAccesoV";
            this.cbxAccesoV.Size = new System.Drawing.Size(100, 21);
            this.cbxAccesoV.TabIndex = 201;
            this.cbxAccesoV.Visible = false;
            // 
            // dtpFechaSes
            // 
            this.dtpFechaSes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSes.Location = new System.Drawing.Point(249, 73);
            this.dtpFechaSes.Name = "dtpFechaSes";
            this.dtpFechaSes.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaSes.TabIndex = 200;
            this.dtpFechaSes.Visible = false;
            // 
            // cbxVIH
            // 
            this.cbxVIH.FormattingEnabled = true;
            this.cbxVIH.Items.AddRange(new object[] {
            "Positivo",
            "Negativo"});
            this.cbxVIH.Location = new System.Drawing.Point(248, 72);
            this.cbxVIH.Name = "cbxVIH";
            this.cbxVIH.Size = new System.Drawing.Size(100, 21);
            this.cbxVIH.TabIndex = 2;
            this.cbxVIH.Visible = false;
            // 
            // FrmConsultaEvolYTrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1081, 652);
            this.Controls.Add(this.cbxVIH);
            this.Controls.Add(this.cbxAccesoV);
            this.Controls.Add(this.dtpFechaSes);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbApellidoMed);
            this.Controls.Add(this.rdbGrupSang);
            this.Controls.Add(this.rdbNameMed);
            this.Controls.Add(this.rdbAccesoVasc);
            this.Controls.Add(this.rdbVIH);
            this.Controls.Add(this.rdbFechaSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParamBusc);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.dgvHojaEvolucionTrat);
            this.Name = "FrmConsultaEvolYTrat";
            this.Text = "FrmConsultaEvolYTrat";
            this.Load += new System.EventHandler(this.FrmConsultaEvolYTrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEvolucionTrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbGrupSang;
        private System.Windows.Forms.RadioButton rdbAccesoVasc;
        private System.Windows.Forms.RadioButton rdbVIH;
        private System.Windows.Forms.RadioButton rdbFechaSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParamBusc;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.DataGridView dgvHojaEvolucionTrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.RadioButton rdbNameMed;
        private System.Windows.Forms.RadioButton rdbApellidoMed;
        private System.Windows.Forms.ComboBox cbxAccesoV;
        private System.Windows.Forms.DateTimePicker dtpFechaSes;
        private System.Windows.Forms.ComboBox cbxVIH;
    }
}