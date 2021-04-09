
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
            this.txtParamBusc = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.dgvHojaMedica = new System.Windows.Forms.DataGridView();
            this.txtGrupoSang = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtSerologia = new System.Windows.Forms.TextBox();
            this.txtPesoSeco = new System.Windows.Forms.TextBox();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.chkVIH = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSolDial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccesoVascular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.btnMenuEmp = new System.Windows.Forms.Button();
            this.txtParamModElim = new System.Windows.Forms.TextBox();
            this.btnModificarRegistros = new System.Windows.Forms.Button();
            this.btnEliminarRegistros = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaMedica)).BeginInit();
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
            this.label10.Location = new System.Drawing.Point(656, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Introduzca CI del paciente";
            // 
            // txtParamBusc
            // 
            this.txtParamBusc.Location = new System.Drawing.Point(656, 478);
            this.txtParamBusc.Name = "txtParamBusc";
            this.txtParamBusc.Size = new System.Drawing.Size(131, 20);
            this.txtParamBusc.TabIndex = 71;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(551, 473);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(99, 29);
            this.btnBuscarRegistros.TabIndex = 70;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(276, 473);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnMostrarRegistros.TabIndex = 69;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click);
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(409, 473);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarRegistros.TabIndex = 68;
            this.btnInsertarRegistros.Text = "Insertar Registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // dgvHojaMedica
            // 
            this.dgvHojaMedica.AllowUserToOrderColumns = true;
            this.dgvHojaMedica.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvHojaMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaMedica.Location = new System.Drawing.Point(20, 60);
            this.dgvHojaMedica.Name = "dgvHojaMedica";
            this.dgvHojaMedica.Size = new System.Drawing.Size(768, 187);
            this.dgvHojaMedica.TabIndex = 67;
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
            this.chkVIH.Location = new System.Drawing.Point(656, 269);
            this.chkVIH.Name = "chkVIH";
            this.chkVIH.Size = new System.Drawing.Size(44, 17);
            this.chkVIH.TabIndex = 59;
            this.chkVIH.Text = "VIH";
            this.chkVIH.UseVisualStyleBackColor = true;
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
            // txtSolDial
            // 
            this.txtSolDial.Location = new System.Drawing.Point(522, 380);
            this.txtSolDial.Name = "txtSolDial";
            this.txtSolDial.Size = new System.Drawing.Size(100, 20);
            this.txtSolDial.TabIndex = 76;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Acceso Vascular";
            // 
            // txtAccesoVascular
            // 
            this.txtAccesoVascular.Location = new System.Drawing.Point(204, 415);
            this.txtAccesoVascular.Name = "txtAccesoVascular";
            this.txtAccesoVascular.Size = new System.Drawing.Size(100, 20);
            this.txtAccesoVascular.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "ID empleado";
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.Location = new System.Drawing.Point(522, 415);
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(100, 20);
            this.txtIDEmp.TabIndex = 76;
            // 
            // btnMenuEmp
            // 
            this.btnMenuEmp.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMenuEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuEmp.Location = new System.Drawing.Point(656, 299);
            this.btnMenuEmp.Name = "btnMenuEmp";
            this.btnMenuEmp.Size = new System.Drawing.Size(112, 28);
            this.btnMenuEmp.TabIndex = 166;
            this.btnMenuEmp.Text = "Menú Empleados";
            this.btnMenuEmp.UseVisualStyleBackColor = false;
            this.btnMenuEmp.Click += new System.EventHandler(this.btnMenuEmp_Click);
            // 
            // txtParamModElim
            // 
            this.txtParamModElim.Location = new System.Drawing.Point(131, 492);
            this.txtParamModElim.Name = "txtParamModElim";
            this.txtParamModElim.Size = new System.Drawing.Size(92, 20);
            this.txtParamModElim.TabIndex = 170;
            // 
            // btnModificarRegistros
            // 
            this.btnModificarRegistros.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModificarRegistros.ForeColor = System.Drawing.SystemColors.Info;
            this.btnModificarRegistros.Location = new System.Drawing.Point(8, 460);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnModificarRegistros.TabIndex = 169;
            this.btnModificarRegistros.Text = "Modificar Registros";
            this.btnModificarRegistros.UseVisualStyleBackColor = false;
            this.btnModificarRegistros.Click += new System.EventHandler(this.btnModificarRegistros_Click);
            // 
            // btnEliminarRegistros
            // 
            this.btnEliminarRegistros.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistros.Location = new System.Drawing.Point(8, 495);
            this.btnEliminarRegistros.Name = "btnEliminarRegistros";
            this.btnEliminarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnEliminarRegistros.TabIndex = 168;
            this.btnEliminarRegistros.Text = "Eliminar Registros";
            this.btnEliminarRegistros.UseVisualStyleBackColor = false;
            this.btnEliminarRegistros.Click += new System.EventHandler(this.btnEliminarRegistros_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(128, 460);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 26);
            this.label17.TabIndex = 167;
            this.label17.Text = "Introduzca ID de\r\nla hoja médica";
            // 
            // FrmHojaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.txtParamModElim);
            this.Controls.Add(this.btnModificarRegistros);
            this.Controls.Add(this.btnEliminarRegistros);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnMenuEmp);
            this.Controls.Add(this.txtIDEmp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSolDial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumUsoFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtParamBusc);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.dgvHojaMedica);
            this.Controls.Add(this.txtGrupoSang);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtAccesoVascular);
            this.Controls.Add(this.txtSerologia);
            this.Controls.Add(this.txtPesoSeco);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.chkVIH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "FrmHojaMedica";
            this.Text = "FrmHojaMedica";
            this.Load += new System.EventHandler(this.FrmHojaMedica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaMedica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumUsoFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParamBusc;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.DataGridView dgvHojaMedica;
        private System.Windows.Forms.TextBox txtGrupoSang;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtSerologia;
        private System.Windows.Forms.TextBox txtPesoSeco;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.CheckBox chkVIH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSolDial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccesoVascular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.Button btnMenuEmp;
        private System.Windows.Forms.TextBox txtParamModElim;
        private System.Windows.Forms.Button btnModificarRegistros;
        private System.Windows.Forms.Button btnEliminarRegistros;
        private System.Windows.Forms.Label label17;
    }
}