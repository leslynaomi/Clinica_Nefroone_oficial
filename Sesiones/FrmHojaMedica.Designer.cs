
namespace capa_presentacion
{
    partial class FrmHojaMedica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumUsoFiltro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.dgvHojaRegistro = new System.Windows.Forms.DataGridView();
            this.txtGrupoSang = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtSerologia = new System.Windows.Forms.TextBox();
            this.txtPesoSeco = new System.Windows.Forms.TextBox();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.chkVIH = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSolucionDializante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAccesoVascular = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoja Médica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Número de uso filtro";
            // 
            // txtNumUsoFiltro
            // 
            this.txtNumUsoFiltro.Location = new System.Drawing.Point(204, 265);
            this.txtNumUsoFiltro.Name = "txtNumUsoFiltro";
            this.txtNumUsoFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtNumUsoFiltro.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(637, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Introduzca CI del paciente";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(637, 458);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(131, 20);
            this.txtParam.TabIndex = 71;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(532, 453);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(99, 29);
            this.btnBuscarRegistros.TabIndex = 70;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(651, 298);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnMostrarRegistros.TabIndex = 69;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(651, 336);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarRegistros.TabIndex = 68;
            this.btnInsertarRegistros.Text = "Insertar Registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            // 
            // dgvHojaRegistro
            // 
            this.dgvHojaRegistro.AllowUserToOrderColumns = true;
            this.dgvHojaRegistro.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvHojaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaRegistro.Location = new System.Drawing.Point(20, 69);
            this.dgvHojaRegistro.Name = "dgvHojaRegistro";
            this.dgvHojaRegistro.Size = new System.Drawing.Size(743, 178);
            this.dgvHojaRegistro.TabIndex = 67;
            // 
            // txtGrupoSang
            // 
            this.txtGrupoSang.Location = new System.Drawing.Point(522, 342);
            this.txtGrupoSang.Name = "txtGrupoSang";
            this.txtGrupoSang.Size = new System.Drawing.Size(100, 20);
            this.txtGrupoSang.TabIndex = 66;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(522, 266);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(100, 20);
            this.txtIMC.TabIndex = 64;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(522, 304);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(100, 20);
            this.txtTalla.TabIndex = 63;
            // 
            // txtSerologia
            // 
            this.txtSerologia.Location = new System.Drawing.Point(204, 379);
            this.txtSerologia.Name = "txtSerologia";
            this.txtSerologia.Size = new System.Drawing.Size(100, 20);
            this.txtSerologia.TabIndex = 62;
            // 
            // txtPesoSeco
            // 
            this.txtPesoSeco.Location = new System.Drawing.Point(204, 342);
            this.txtPesoSeco.Name = "txtPesoSeco";
            this.txtPesoSeco.Size = new System.Drawing.Size(100, 20);
            this.txtPesoSeco.TabIndex = 61;
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(204, 304);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(100, 20);
            this.txtDiagnostic.TabIndex = 60;
            // 
            // chkVIH
            // 
            this.chkVIH.AutoSize = true;
            this.chkVIH.Location = new System.Drawing.Point(30, 460);
            this.chkVIH.Name = "chkVIH";
            this.chkVIH.Size = new System.Drawing.Size(44, 17);
            this.chkVIH.TabIndex = 59;
            this.chkVIH.Text = "VIH";
            this.chkVIH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(651, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 57;
            this.button1.Text = "Menú Pacientes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Grupo sanguíneo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Talla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Serología";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Peso seco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Índice de masa corporal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Diagnóstico";
            // 
            // txtSolucionDializante
            // 
            this.txtSolucionDializante.Location = new System.Drawing.Point(522, 380);
            this.txtSolucionDializante.Name = "txtSolucionDializante";
            this.txtSolucionDializante.Size = new System.Drawing.Size(100, 20);
            this.txtSolucionDializante.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Solución dializante";
            // 
            // chkAccesoVascular
            // 
            this.chkAccesoVascular.AutoSize = true;
            this.chkAccesoVascular.Location = new System.Drawing.Point(103, 461);
            this.chkAccesoVascular.Name = "chkAccesoVascular";
            this.chkAccesoVascular.Size = new System.Drawing.Size(106, 17);
            this.chkAccesoVascular.TabIndex = 77;
            this.chkAccesoVascular.Text = "Acceso Vascular";
            this.chkAccesoVascular.UseVisualStyleBackColor = true;
            // 
            // FrmHojaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.chkAccesoVascular);
            this.Controls.Add(this.txtSolucionDializante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumUsoFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.dgvHojaRegistro);
            this.Controls.Add(this.txtGrupoSang);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtSerologia);
            this.Controls.Add(this.txtPesoSeco);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.chkVIH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "FrmHojaMedica";
            this.Text = "FrmHojaMedica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumUsoFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.DataGridView dgvHojaRegistro;
        private System.Windows.Forms.TextBox txtGrupoSang;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtSerologia;
        private System.Windows.Forms.TextBox txtPesoSeco;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.CheckBox chkVIH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSolucionDializante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAccesoVascular;
    }
}