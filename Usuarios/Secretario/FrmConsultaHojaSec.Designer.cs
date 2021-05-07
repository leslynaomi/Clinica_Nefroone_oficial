
namespace capa_presentacion
{
    partial class FrmConsultaHojaSec
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
            this.dgvConsultaHojaSec = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaHojaSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(26, 444);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(117, 31);
            this.btnMostrarRegistros.TabIndex = 56;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            this.btnMostrarRegistros.Click += new System.EventHandler(this.btnMostrarRegistros_Click);
            // 
            // dgvConsultaHojaSec
            // 
            this.dgvConsultaHojaSec.AllowUserToOrderColumns = true;
            this.dgvConsultaHojaSec.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dgvConsultaHojaSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaHojaSec.Location = new System.Drawing.Point(26, 59);
            this.dgvConsultaHojaSec.Name = "dgvConsultaHojaSec";
            this.dgvConsultaHojaSec.ReadOnly = true;
            this.dgvConsultaHojaSec.Size = new System.Drawing.Size(960, 379);
            this.dgvConsultaHojaSec.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Consulta Hoja Secretaría";
            // 
            // FrmConsultaHojaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1020, 487);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.dgvConsultaHojaSec);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaHojaSec";
            this.Text = "FrmConsultaHojaSec";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaHojaSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvConsultaHojaSec;
    }
}