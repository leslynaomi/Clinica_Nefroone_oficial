
namespace capa_presentacion
{
    partial class FrmPrincipalAdministrador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnSecretaria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnEnfermera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(12, 187);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.Text = "Volver";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnSecretaria
            // 
            this.btnSecretaria.Location = new System.Drawing.Point(203, 99);
            this.btnSecretaria.Name = "btnSecretaria";
            this.btnSecretaria.Size = new System.Drawing.Size(75, 23);
            this.btnSecretaria.TabIndex = 3;
            this.btnSecretaria.Text = "Secretaría";
            this.btnSecretaria.UseVisualStyleBackColor = true;
            this.btnSecretaria.Click += new System.EventHandler(this.btnSecretaria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cada actor iniciando sesión";
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(203, 159);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 5;
            this.btnMedico.Text = "Médico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnEnfermera
            // 
            this.btnEnfermera.Location = new System.Drawing.Point(203, 129);
            this.btnEnfermera.Name = "btnEnfermera";
            this.btnEnfermera.Size = new System.Drawing.Size(75, 23);
            this.btnEnfermera.TabIndex = 6;
            this.btnEnfermera.Text = "Enfermera";
            this.btnEnfermera.UseVisualStyleBackColor = true;
            this.btnEnfermera.Click += new System.EventHandler(this.btnEnfermera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENTORNO DE PRUEBA";
            // 
            // FrmPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(321, 222);
            this.Controls.Add(this.btnEnfermera);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecretaria);
            this.Controls.Add(this.btnVolverMenu);
            this.Name = "FrmPrincipalAdministrador";
            this.Text = "Menu Administrador(a)";
            this.Load += new System.EventHandler(this.FrmPrincipalAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnSecretaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnEnfermera;
        private System.Windows.Forms.Label label2;
    }
}

