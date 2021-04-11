
namespace capa_presentacion.Usuarios.Farmaceutico
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
            this.textNameMedic = new System.Windows.Forms.TextBox();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPresentacion = new System.Windows.Forms.TextBox();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarRegistros = new System.Windows.Forms.Button();
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.textIdMed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textConcentracion = new System.Windows.Forms.TextBox();
            this.textDiagnostico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.SuspendLayout();
            // 
            // textNameMedic
            // 
            this.textNameMedic.Location = new System.Drawing.Point(889, 135);
            this.textNameMedic.Name = "textNameMedic";
            this.textNameMedic.Size = new System.Drawing.Size(199, 20);
            this.textNameMedic.TabIndex = 0;
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Location = new System.Drawing.Point(42, 66);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamento.Size = new System.Drawing.Size(646, 439);
            this.dgvMedicamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Medicamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(708, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Producto";
            // 
            // textPresentacion
            // 
            this.textPresentacion.Location = new System.Drawing.Point(889, 171);
            this.textPresentacion.Name = "textPresentacion";
            this.textPresentacion.Size = new System.Drawing.Size(199, 20);
            this.textPresentacion.TabIndex = 4;
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(841, 376);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarRegistros.TabIndex = 69;
            this.btnInsertarRegistros.Text = "Insertar Registros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Listado de Insumos Medicos";
            // 
            // btnModificarRegistros
            // 
            this.btnModificarRegistros.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModificarRegistros.ForeColor = System.Drawing.SystemColors.Info;
            this.btnModificarRegistros.Location = new System.Drawing.Point(1001, 376);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnModificarRegistros.TabIndex = 71;
            this.btnModificarRegistros.Text = "Modificar Registros";
            this.btnModificarRegistros.UseVisualStyleBackColor = false;
            this.btnModificarRegistros.Click += new System.EventHandler(this.btnModificarRegistros_Click);
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(743, 32);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnBuscarRegistros.TabIndex = 97;
            this.btnBuscarRegistros.Text = "Buscar Registros";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // textIdMed
            // 
            this.textIdMed.Location = new System.Drawing.Point(889, 37);
            this.textIdMed.Name = "textIdMed";
            this.textIdMed.Size = new System.Drawing.Size(199, 20);
            this.textIdMed.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(706, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Presentacion";
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(889, 250);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(199, 20);
            this.textStock.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(708, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 102;
            this.label5.Text = "Concentracion";
            // 
            // textConcentracion
            // 
            this.textConcentracion.Location = new System.Drawing.Point(889, 210);
            this.textConcentracion.Name = "textConcentracion";
            this.textConcentracion.Size = new System.Drawing.Size(199, 20);
            this.textConcentracion.TabIndex = 101;
            // 
            // textDiagnostico
            // 
            this.textDiagnostico.Location = new System.Drawing.Point(889, 293);
            this.textDiagnostico.Name = "textDiagnostico";
            this.textDiagnostico.Size = new System.Drawing.Size(199, 20);
            this.textDiagnostico.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(708, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 103;
            this.label6.Text = "Tipo Diagnostico";
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.textPresentacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.TextBox textNameMedic;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPresentacion;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarRegistros;
        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.TextBox textIdMed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textConcentracion;
        private System.Windows.Forms.TextBox textDiagnostico;
        private System.Windows.Forms.Label label6;
    }
}