
namespace capa_presentacion.Pacientes
{
    partial class FormGestionarPaciente
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
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.btnMostrarRegistros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtParamModElim = new System.Windows.Forms.TextBox();
            this.btnModificarRegistros = new System.Windows.Forms.Button();
            this.btnEliminarRegistros = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaciente
            // 
            this.dgvPaciente.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Location = new System.Drawing.Point(278, 71);
            this.dgvPaciente.Name = "dgvPaciente";
            this.dgvPaciente.Size = new System.Drawing.Size(941, 565);
            this.dgvPaciente.TabIndex = 30;
            // 
            // btnMostrarRegistros
            // 
            this.btnMostrarRegistros.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMostrarRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMostrarRegistros.Location = new System.Drawing.Point(27, 71);
            this.btnMostrarRegistros.Name = "btnMostrarRegistros";
            this.btnMostrarRegistros.Size = new System.Drawing.Size(224, 29);
            this.btnMostrarRegistros.TabIndex = 29;
            this.btnMostrarRegistros.Text = "Mostrar Registros";
            this.btnMostrarRegistros.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(611, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Área Pacientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cédula de Identidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 191);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(151, 367);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtPaterno.TabIndex = 40;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(151, 237);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtMaterno.TabIndex = 41;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(151, 150);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(100, 20);
            this.txtCi.TabIndex = 42;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(152, 283);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 43;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(151, 457);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 44;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(152, 326);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 45;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(151, 413);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 46;
            // 
            // txtParamModElim
            // 
            this.txtParamModElim.Location = new System.Drawing.Point(146, 581);
            this.txtParamModElim.Name = "txtParamModElim";
            this.txtParamModElim.Size = new System.Drawing.Size(98, 20);
            this.txtParamModElim.TabIndex = 167;
            // 
            // btnModificarRegistros
            // 
            this.btnModificarRegistros.BackColor = System.Drawing.Color.DarkGreen;
            this.btnModificarRegistros.ForeColor = System.Drawing.SystemColors.Info;
            this.btnModificarRegistros.Location = new System.Drawing.Point(20, 501);
            this.btnModificarRegistros.Name = "btnModificarRegistros";
            this.btnModificarRegistros.Size = new System.Drawing.Size(231, 29);
            this.btnModificarRegistros.TabIndex = 166;
            this.btnModificarRegistros.Text = "Modificar Registros";
            this.btnModificarRegistros.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRegistros
            // 
            this.btnEliminarRegistros.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnEliminarRegistros.Location = new System.Drawing.Point(19, 607);
            this.btnEliminarRegistros.Name = "btnEliminarRegistros";
            this.btnEliminarRegistros.Size = new System.Drawing.Size(232, 29);
            this.btnEliminarRegistros.TabIndex = 165;
            this.btnEliminarRegistros.Text = "Eliminar Registros";
            this.btnEliminarRegistros.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 575);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 26);
            this.label17.TabIndex = 164;
            this.label17.Text = "Introduzca el carnet de \r\ndentidad del paciente:";
            // 
            // FormGestionarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtParamModElim);
            this.Controls.Add(this.btnModificarRegistros);
            this.Controls.Add(this.btnEliminarRegistros);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtCi);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPaciente);
            this.Controls.Add(this.btnMostrarRegistros);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionarPaciente";
            this.Text = "FormGestionarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.Button btnMostrarRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtParamModElim;
        private System.Windows.Forms.Button btnModificarRegistros;
        private System.Windows.Forms.Button btnEliminarRegistros;
        private System.Windows.Forms.Label label17;
    }
}