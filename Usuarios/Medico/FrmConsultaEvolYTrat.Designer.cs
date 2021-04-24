
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
            this.rdbEdad = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbCi = new System.Windows.Forms.RadioButton();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParamBusc = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.dgvHojaEvolucionTrat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHojaEvolucionTrat)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbEdad
            // 
            this.rdbEdad.AutoSize = true;
            this.rdbEdad.Location = new System.Drawing.Point(686, 93);
            this.rdbEdad.Name = "rdbEdad";
            this.rdbEdad.Size = new System.Drawing.Size(50, 17);
            this.rdbEdad.TabIndex = 196;
            this.rdbEdad.TabStop = true;
            this.rdbEdad.Text = "Edad";
            this.rdbEdad.UseVisualStyleBackColor = true;
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(456, 93);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(62, 17);
            this.rdbApellido.TabIndex = 194;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            // 
            // rdbCi
            // 
            this.rdbCi.AutoSize = true;
            this.rdbCi.Location = new System.Drawing.Point(546, 93);
            this.rdbCi.Name = "rdbCi";
            this.rdbCi.Size = new System.Drawing.Size(118, 17);
            this.rdbCi.TabIndex = 195;
            this.rdbCi.TabStop = true;
            this.rdbCi.Text = "Carnet de Identidad";
            this.rdbCi.UseVisualStyleBackColor = true;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(375, 93);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(62, 17);
            this.rdbName.TabIndex = 193;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Nombre";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 197;
            this.label2.Text = "Buscar por:";
            // 
            // txtParamBusc
            // 
            this.txtParamBusc.Location = new System.Drawing.Point(142, 92);
            this.txtParamBusc.Name = "txtParamBusc";
            this.txtParamBusc.Size = new System.Drawing.Size(106, 20);
            this.txtParamBusc.TabIndex = 192;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(28, 87);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(108, 29);
            this.btnBuscarRegistros.TabIndex = 191;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // dgvHojaEvolucionTrat
            // 
            this.dgvHojaEvolucionTrat.AllowUserToOrderColumns = true;
            this.dgvHojaEvolucionTrat.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvHojaEvolucionTrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHojaEvolucionTrat.Location = new System.Drawing.Point(28, 122);
            this.dgvHojaEvolucionTrat.Name = "dgvHojaEvolucionTrat";
            this.dgvHojaEvolucionTrat.Size = new System.Drawing.Size(1027, 505);
            this.dgvHojaEvolucionTrat.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 198;
            this.label1.Text = "Consulta de Datos";
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(785, 87);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(120, 29);
            this.btnMostrarRegistros.TabIndex = 199;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click);
            // 
            // FrmConsultaEvolYTrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1081, 652);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbEdad);
            this.Controls.Add(this.rdbApellido);
            this.Controls.Add(this.rdbCi);
            this.Controls.Add(this.rdbName);
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

        private System.Windows.Forms.RadioButton rdbEdad;
        private System.Windows.Forms.RadioButton rdbApellido;
        private System.Windows.Forms.RadioButton rdbCi;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParamBusc;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.DataGridView dgvHojaEvolucionTrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarRegistros;
    }
}