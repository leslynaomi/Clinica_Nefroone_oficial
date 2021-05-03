
namespace capa_presentacion
{
    partial class FrmConsultarPacientes
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbCi = new System.Windows.Forms.RadioButton();
            this.rdbEdad = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(277, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Pacientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Buscar por:";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(179, 70);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(119, 20);
            this.txtParam.TabIndex = 29;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(35, 65);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnBuscarRegistros.TabIndex = 28;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(35, 102);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.Size = new System.Drawing.Size(753, 350);
            this.dgvPaciente.TabIndex = 31;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(410, 75);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(62, 17);
            this.rdbName.TabIndex = 32;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Nombre";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbCi
            // 
            this.rdbCi.AutoSize = true;
            this.rdbCi.Location = new System.Drawing.Point(573, 75);
            this.rdbCi.Name = "rdbCi";
            this.rdbCi.Size = new System.Drawing.Size(118, 17);
            this.rdbCi.TabIndex = 32;
            this.rdbCi.TabStop = true;
            this.rdbCi.Text = "Carnet de Identidad";
            this.rdbCi.UseVisualStyleBackColor = true;
            // 
            // rdbEdad
            // 
            this.rdbEdad.AutoSize = true;
            this.rdbEdad.Location = new System.Drawing.Point(713, 75);
            this.rdbEdad.Name = "rdbEdad";
            this.rdbEdad.Size = new System.Drawing.Size(50, 17);
            this.rdbEdad.TabIndex = 32;
            this.rdbEdad.TabStop = true;
            this.rdbEdad.Text = "Edad";
            this.rdbEdad.UseVisualStyleBackColor = true;
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(491, 75);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(62, 17);
            this.rdbApellido.TabIndex = 32;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(826, 478);
            this.Controls.Add(this.rdbEdad);
            this.Controls.Add(this.rdbApellido);
            this.Controls.Add(this.rdbCi);
            this.Controls.Add(this.rdbName);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultarPacientes";
            this.Text = "FrmConsultarPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbCi;
        private System.Windows.Forms.RadioButton rdbEdad;
        private System.Windows.Forms.RadioButton rdbApellido;
    }
}