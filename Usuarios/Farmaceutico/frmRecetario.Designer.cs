
namespace capa_presentacion.Usuarios.Farmaceutico
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
            this.dgvMedicamento = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbPeritoneal = new System.Windows.Forms.RadioButton();
            this.rbCateter = new System.Windows.Forms.RadioButton();
            this.rbFistula = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.dgvreceta = new System.Windows.Forms.DataGridView();
            this.txtIdMedicamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamento.Location = new System.Drawing.Point(12, 235);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            this.dgvMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamento.Size = new System.Drawing.Size(514, 357);
            this.dgvMedicamento.TabIndex = 0;
            this.dgvMedicamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMedicamento_MouseClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(910, 221);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(90, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(75, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diagnostico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hemodialisis por Cateter (Por Sesion)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hemodialisis por Fistula Arteriovenosa (Por Sesion)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dialisis Peritoneal(Por Sesion)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtPaciente);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.txtIdMedico);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
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
            this.panel1.Size = new System.Drawing.Size(1047, 176);
            this.panel1.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(136, 23);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(188, 20);
            this.txtFecha.TabIndex = 103;
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(896, 9);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(112, 20);
            this.txtIdMedico.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Fecha :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(796, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 102;
            this.label7.Text = "id_medico";
            // 
            // rbPeritoneal
            // 
            this.rbPeritoneal.AutoSize = true;
            this.rbPeritoneal.Location = new System.Drawing.Point(448, 144);
            this.rbPeritoneal.Name = "rbPeritoneal";
            this.rbPeritoneal.Size = new System.Drawing.Size(14, 13);
            this.rbPeritoneal.TabIndex = 9;
            this.rbPeritoneal.TabStop = true;
            this.rbPeritoneal.UseVisualStyleBackColor = true;
            this.rbPeritoneal.CheckedChanged += new System.EventHandler(this.rbPeritoneal_CheckedChanged);
            // 
            // rbCateter
            // 
            this.rbCateter.AutoSize = true;
            this.rbCateter.Location = new System.Drawing.Point(448, 114);
            this.rbCateter.Name = "rbCateter";
            this.rbCateter.Size = new System.Drawing.Size(14, 13);
            this.rbCateter.TabIndex = 8;
            this.rbCateter.TabStop = true;
            this.rbCateter.UseVisualStyleBackColor = true;
            this.rbCateter.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbFistula
            // 
            this.rbFistula.AutoSize = true;
            this.rbFistula.Location = new System.Drawing.Point(448, 85);
            this.rbFistula.Name = "rbFistula";
            this.rbFistula.Size = new System.Drawing.Size(14, 13);
            this.rbFistula.TabIndex = 7;
            this.rbFistula.TabStop = true;
            this.rbFistula.UseVisualStyleBackColor = true;
            this.rbFistula.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(873, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad Recetada";
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnInsertarRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnInsertarRegistros.Location = new System.Drawing.Point(604, 216);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(117, 29);
            this.btnInsertarRegistros.TabIndex = 69;
            this.btnInsertarRegistros.Text = "Insertar ";
            this.btnInsertarRegistros.UseVisualStyleBackColor = false;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // dgvreceta
            // 
            this.dgvreceta.AllowUserToAddRows = false;
            this.dgvreceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreceta.Location = new System.Drawing.Point(614, 266);
            this.dgvreceta.Name = "dgvreceta";
            this.dgvreceta.ReadOnly = true;
            this.dgvreceta.Size = new System.Drawing.Size(393, 326);
            this.dgvreceta.TabIndex = 99;
            // 
            // txtIdMedicamento
            // 
            this.txtIdMedicamento.Location = new System.Drawing.Point(753, 221);
            this.txtIdMedicamento.Name = "txtIdMedicamento";
            this.txtIdMedicamento.Size = new System.Drawing.Size(90, 20);
            this.txtIdMedicamento.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 100;
            this.label6.Text = "id_medicamento";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(896, 42);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(112, 20);
            this.txtPaciente.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(788, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 104;
            this.label9.Text = "id_Paciente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(896, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 102;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmRecetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdMedicamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvreceta);
            this.Controls.Add(this.btnInsertarRegistros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicamento);
            this.Name = "frmRecetario";
            this.Text = "frmRecetario";
            this.Load += new System.EventHandler(this.frmRecetario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicamento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPeritoneal;
        private System.Windows.Forms.RadioButton rbCateter;
        private System.Windows.Forms.RadioButton rbFistula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.DataGridView dgvreceta;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdMedicamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}