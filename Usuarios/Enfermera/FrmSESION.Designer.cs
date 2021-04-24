
namespace capa_presentacion
{
    partial class FrmSESION
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
            this.txtinsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textidsesion = new System.Windows.Forms.TextBox();
            this.textpesofinal = new System.Windows.Forms.TextBox();
            this.textpesoinicial = new System.Windows.Forms.TextBox();
            this.txtmostrar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.Button();
            this.datesesion = new System.Windows.Forms.DateTimePicker();
            this.textbuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textidempleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textidhojas = new System.Windows.Forms.TextBox();
            this.textidnota = new System.Windows.Forms.TextBox();
            this.clinicaDataSet = new capa_presentacion.ClinicaDataSet();
            this.clinicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtinsertar
            // 
            this.txtinsertar.Location = new System.Drawing.Point(76, 418);
            this.txtinsertar.Name = "txtinsertar";
            this.txtinsertar.Size = new System.Drawing.Size(121, 23);
            this.txtinsertar.TabIndex = 0;
            this.txtinsertar.Text = "Insertar";
            this.txtinsertar.UseVisualStyleBackColor = true;
            this.txtinsertar.Click += new System.EventHandler(this.txtinsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SESIONES";
            // 
            // data
            // 
            this.data.AllowUserToOrderColumns = true;
            this.data.AutoGenerateColumns = false;
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.DataSource = this.clinicaDataSetBindingSource;
            this.data.Location = new System.Drawing.Point(335, 107);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(404, 224);
            this.data.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha_Sesion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso_Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Peso_final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Id_Sesion";
            // 
            // textidsesion
            // 
            this.textidsesion.Location = new System.Drawing.Point(107, 278);
            this.textidsesion.Name = "textidsesion";
            this.textidsesion.Size = new System.Drawing.Size(100, 20);
            this.textidsesion.TabIndex = 8;
            // 
            // textpesofinal
            // 
            this.textpesofinal.Location = new System.Drawing.Point(107, 190);
            this.textpesofinal.Name = "textpesofinal";
            this.textpesofinal.Size = new System.Drawing.Size(100, 20);
            this.textpesofinal.TabIndex = 9;
            // 
            // textpesoinicial
            // 
            this.textpesoinicial.Location = new System.Drawing.Point(107, 144);
            this.textpesoinicial.Name = "textpesoinicial";
            this.textpesoinicial.Size = new System.Drawing.Size(100, 20);
            this.textpesoinicial.TabIndex = 10;
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(63, 97);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(118, 23);
            this.txtmostrar.TabIndex = 11;
            this.txtmostrar.Text = "Mostrar";
            this.txtmostrar.UseVisualStyleBackColor = true;
            this.txtmostrar.Click += new System.EventHandler(this.txtmostrar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(335, 354);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(113, 23);
            this.txtbuscar.TabIndex = 13;
            this.txtbuscar.Text = "Buscar";
            this.txtbuscar.UseVisualStyleBackColor = true;
            this.txtbuscar.Click += new System.EventHandler(this.txtbuscar_Click);
            // 
            // datesesion
            // 
            this.datesesion.Location = new System.Drawing.Point(107, 233);
            this.datesesion.Name = "datesesion";
            this.datesesion.Size = new System.Drawing.Size(200, 20);
            this.datesesion.TabIndex = 50;
            // 
            // textbuscar
            // 
            this.textbuscar.Location = new System.Drawing.Point(483, 357);
            this.textbuscar.Name = "textbuscar";
            this.textbuscar.Size = new System.Drawing.Size(100, 20);
            this.textbuscar.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Id_Empleado";
            // 
            // textidempleado
            // 
            this.textidempleado.Location = new System.Drawing.Point(107, 315);
            this.textidempleado.Name = "textidempleado";
            this.textidempleado.Size = new System.Drawing.Size(100, 20);
            this.textidempleado.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Id_Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Id_Hojas";
            // 
            // textidhojas
            // 
            this.textidhojas.Location = new System.Drawing.Point(107, 392);
            this.textidhojas.Name = "textidhojas";
            this.textidhojas.Size = new System.Drawing.Size(100, 20);
            this.textidhojas.TabIndex = 56;
            // 
            // textidnota
            // 
            this.textidnota.Location = new System.Drawing.Point(107, 354);
            this.textidnota.Name = "textidnota";
            this.textidnota.Size = new System.Drawing.Size(100, 20);
            this.textidnota.TabIndex = 57;
            // 
            // clinicaDataSet
            // 
            this.clinicaDataSet.DataSetName = "ClinicaDataSet";
            this.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicaDataSetBindingSource
            // 
            this.clinicaDataSetBindingSource.DataSource = this.clinicaDataSet;
            this.clinicaDataSetBindingSource.Position = 0;
            // 
            // FrmSESION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textidnota);
            this.Controls.Add(this.textidhojas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textidempleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbuscar);
            this.Controls.Add(this.datesesion);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.textpesoinicial);
            this.Controls.Add(this.textpesofinal);
            this.Controls.Add(this.textidsesion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinsertar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmSESION";
            this.Text = "FrmSESION";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtinsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textidsesion;
        private System.Windows.Forms.TextBox textpesofinal;
        private System.Windows.Forms.TextBox textpesoinicial;
        private System.Windows.Forms.Button txtmostrar;
        private System.Windows.Forms.Button txtbuscar;
        private System.Windows.Forms.DateTimePicker datesesion;
        private System.Windows.Forms.TextBox textbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textidempleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textidhojas;
        private System.Windows.Forms.TextBox textidnota;
        private System.Windows.Forms.BindingSource clinicaDataSetBindingSource;
        private ClinicaDataSet clinicaDataSet;
    }
}