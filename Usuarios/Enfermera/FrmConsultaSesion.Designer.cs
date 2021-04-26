
namespace capa_presentacion
{
    partial class FrmConsultaSesion
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
            this.components = new System.ComponentModel.Container();
            this.clinicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.dgvConsultaSesion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(316, 412);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(107, 20);
            this.textbuscar.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 79;
            this.label1.Text = "SESIONES";
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(193, 407);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(107, 29);
            this.btnBuscarRegistros.TabIndex = 192;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(55, 407);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(107, 29);
            this.btnMostrarRegistros.TabIndex = 191;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click);
            // 
            // dgvConsultaSesion
            // 
            this.dgvConsultaSesion.AllowUserToOrderColumns = true;
            this.dgvConsultaSesion.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvConsultaSesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaSesion.Location = new System.Drawing.Point(38, 73);
            this.dgvConsultaSesion.Name = "dgvConsultaSesion";
            this.dgvConsultaSesion.ReadOnly = true;
            this.dgvConsultaSesion.Size = new System.Drawing.Size(674, 311);
            this.dgvConsultaSesion.TabIndex = 193;
            // 
            // FrmConsultaSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(757, 458);
            this.Controls.Add(this.dgvConsultaSesion);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaSesion";
            this.Text = "FrmSesion";
            this.Load += new System.EventHandler(this.FrmSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clinicaDataSetBindingSource;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.Button btnMostrarRegistros;
        public System.Windows.Forms.DataGridView dgvConsultaSesion;
    }
}