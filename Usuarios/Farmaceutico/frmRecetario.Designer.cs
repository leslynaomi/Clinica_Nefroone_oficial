
namespace capa_presentacion
{
    partial class frmRecetario
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
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvreceta = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbPeritoneal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCateter = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.rbFistula = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(883, 642);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 29);
            this.button3.TabIndex = 110;
            this.button3.Text = "RECETAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(703, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 29);
            this.label11.TabIndex = 113;
            this.label11.Text = "RECETARIO/RECIBO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(77, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 29);
            this.label10.TabIndex = 112;
            this.label10.Text = "LISTA DE MEDICAMENTOS";
            // 
            // dgvreceta
            // 
            this.dgvreceta.AllowUserToAddRows = false;
            this.dgvreceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreceta.Location = new System.Drawing.Point(614, 288);
            this.dgvreceta.Name = "dgvreceta";
            this.dgvreceta.ReadOnly = true;
            this.dgvreceta.Size = new System.Drawing.Size(393, 326);
            this.dgvreceta.TabIndex = 111;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(888, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "NUEVO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(888, 87);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(112, 20);
            this.txtPaciente.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(144, 23);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(143, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(781, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 116;
            this.label9.Text = "id_Paciente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(909, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "consultar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "Fecha :";
            // 
            // rbPeritoneal
            // 
            this.rbPeritoneal.AutoSize = true;
            this.rbPeritoneal.Location = new System.Drawing.Point(434, 144);
            this.rbPeritoneal.Name = "rbPeritoneal";
            this.rbPeritoneal.Size = new System.Drawing.Size(14, 13);
            this.rbPeritoneal.TabIndex = 113;
            this.rbPeritoneal.TabStop = true;
            this.rbPeritoneal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(880, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 105;
            this.label1.Text = "Cantidad Recetada";
            // 
            // rbCateter
            // 
            this.rbCateter.AutoSize = true;
            this.rbCateter.Location = new System.Drawing.Point(434, 114);
            this.rbCateter.Name = "rbCateter";
            this.rbCateter.Size = new System.Drawing.Size(14, 13);
            this.rbCateter.TabIndex = 112;
            this.rbCateter.TabStop = true;
            this.rbCateter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(61, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "Diagnostico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 15);
            this.label5.TabIndex = 110;
            this.label5.Text = "Dialisis Peritoneal(Por Sesion)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 15);
            this.label4.TabIndex = 109;
            this.label4.Text = "Hemodialisis por Fistula Arteriovenosa (Por Sesion)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 15);
            this.label3.TabIndex = 108;
            this.label3.Text = "Hemodialisis por Cateter (Por Sesion)";
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertarRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Image = global::capa_presentacion.Properties.Resources.iconfinder_compose_1055085;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(607, 209);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(73, 67);
            this.btnInsertarRegistros.TabIndex = 108;
            this.btnInsertarRegistros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(910, 256);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(90, 20);
            this.txtCantidad.TabIndex = 107;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "seleccion";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMedicamento.Location = new System.Drawing.Point(12, 249);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamento.Size = new System.Drawing.Size(531, 357);
            this.dgvMedicamento.TabIndex = 106;
            // 
            // rbFistula
            // 
            this.rbFistula.AutoSize = true;
            this.rbFistula.Location = new System.Drawing.Point(434, 85);
            this.rbFistula.Name = "rbFistula";
            this.rbFistula.Size = new System.Drawing.Size(14, 13);
            this.rbFistula.TabIndex = 111;
            this.rbFistula.TabStop = true;
            this.rbFistula.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtPaciente);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rbPeritoneal);
            this.panel1.Controls.Add(this.rbCateter);
            this.panel1.Controls.Add(this.rbFistula);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 167);
            this.panel1.TabIndex = 109;
            // 
            // frmRecetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 685);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvreceta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.panel1);
            this.Name = "frmRecetario";
            this.Text = "frmRecetario";
            this.Load += new System.EventHandler(this.frmRecetario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvreceta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPeritoneal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCateter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.RadioButton rbFistula;
        private System.Windows.Forms.Panel panel1;
    }
}