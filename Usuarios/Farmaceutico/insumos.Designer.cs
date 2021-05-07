
namespace capa_presentacion
{
    partial class insumos
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
            this.textDiagnostico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textConcentracion = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdMed = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.btnModificarRegistros = new System.Windows.Forms.Button();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.textPresentacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.textNameMedic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // textDiagnostico
            // 
            this.textDiagnostico.Location = new System.Drawing.Point(891, 287);
            this.textDiagnostico.Name = "textDiagnostico";
            this.textDiagnostico.Size = new System.Drawing.Size(199, 20);
            this.textDiagnostico.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(710, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 119;
            this.label6.Text = "Tipo Diagnostico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Concentracion";
            // 
            // textConcentracion
            // 
            this.textConcentracion.Location = new System.Drawing.Point(891, 204);
            this.textConcentracion.Name = "textConcentracion";
            this.textConcentracion.Size = new System.Drawing.Size(199, 20);
            this.textConcentracion.TabIndex = 117;
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(891, 244);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(199, 20);
            this.textStock.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(708, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 115;
            this.label4.Text = "Presentacion";
            // 
            // textIdMed
            // 
            this.textIdMed.Location = new System.Drawing.Point(891, 31);
            this.textIdMed.Name = "textIdMed";
            this.textIdMed.Size = new System.Drawing.Size(95, 20);
            this.textIdMed.TabIndex = 114;
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(745, 26);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnBuscarRegistros.TabIndex = 113;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            // 
            // btnModificarRegistros
            // 
            this.btnModificarRegistros.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModificarRegistros.ForeColor = System.Drawing.SystemColors.Info;
            this.btnModificarRegistros.Location = new System.Drawing.Point(1003, 370);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnModificarRegistros.TabIndex = 112;
            this.btnModificarRegistros.Text = "Modificar Registros";
            this.btnModificarRegistros.UseVisualStyleBackColor = false;
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(745, 347);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarRegistros.TabIndex = 110;
            this.btnInsertarRegistros.Text = "Insertar Registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click_1);
            // 
            // textPresentacion
            // 
            this.textPresentacion.Location = new System.Drawing.Point(891, 165);
            this.textPresentacion.Name = "textPresentacion";
            this.textPresentacion.Size = new System.Drawing.Size(199, 20);
            this.textPresentacion.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "Stock Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 107;
            this.label1.Text = "Nombre del Medicamento";
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "selecion";
            this.Column1.Name = "Column1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 24);
            this.label3.TabIndex = 111;
            this.label3.Text = "Listado de Insumos Medicos";
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMedicamento.Location = new System.Drawing.Point(44, 60);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamento.Size = new System.Drawing.Size(646, 439);
            this.dgvMedicamento.TabIndex = 106;
            // 
            // textNameMedic
            // 
            this.textNameMedic.Location = new System.Drawing.Point(891, 129);
            this.textNameMedic.Name = "textNameMedic";
            this.textNameMedic.Size = new System.Drawing.Size(199, 20);
            this.textNameMedic.TabIndex = 105;
            // 
            // insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1153, 553);
            this.Controls.Add(this.textDiagnostico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textConcentracion);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textIdMed);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Controls.Add(this.btnModificarRegistros);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.textPresentacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.textNameMedic);
            this.Name = "insumos";
            this.Text = "insumos";
            this.Load += new System.EventHandler(this.insumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDiagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textConcentracion;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIdMed;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.Button btnModificarRegistros;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.TextBox textPresentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.TextBox textNameMedic;
    }
}