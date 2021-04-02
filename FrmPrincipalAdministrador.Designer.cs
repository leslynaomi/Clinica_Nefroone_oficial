
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
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.btnSaludMenu = new System.Windows.Forms.Button();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnSecretaria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnEnfermera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Location = new System.Drawing.Point(103, 94);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(133, 48);
            this.btnAdminMenu.TabIndex = 0;
            this.btnAdminMenu.Text = "Area Administrativa";
            this.btnAdminMenu.UseVisualStyleBackColor = true;
            // 
            // btnSaludMenu
            // 
            this.btnSaludMenu.Location = new System.Drawing.Point(298, 94);
            this.btnSaludMenu.Name = "btnSaludMenu";
            this.btnSaludMenu.Size = new System.Drawing.Size(133, 48);
            this.btnSaludMenu.TabIndex = 1;
            this.btnSaludMenu.Text = "Area Salud";
            this.btnSaludMenu.UseVisualStyleBackColor = true;
            this.btnSaludMenu.Click += new System.EventHandler(this.btnSaludMenu_Click);
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(31, 244);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMenu.TabIndex = 2;
            this.btnVolverMenu.Text = "Volver";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // btnSecretaria
            // 
            this.btnSecretaria.Location = new System.Drawing.Point(454, 166);
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
            this.label1.Location = new System.Drawing.Point(451, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vistas a Probar";
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(454, 195);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 23);
            this.btnMedico.TabIndex = 5;
            this.btnMedico.Text = "Médico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnEnfermera
            // 
            this.btnEnfermera.Location = new System.Drawing.Point(454, 224);
            this.btnEnfermera.Name = "btnEnfermera";
            this.btnEnfermera.Size = new System.Drawing.Size(75, 23);
            this.btnEnfermera.TabIndex = 6;
            this.btnEnfermera.Text = "Enfermera";
            this.btnEnfermera.UseVisualStyleBackColor = true;
            this.btnEnfermera.Click += new System.EventHandler(this.btnEnfermera_Click);
            // 
            // FrmPrincipalAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 295);
            this.Controls.Add(this.btnEnfermera);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecretaria);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnSaludMenu);
            this.Controls.Add(this.btnAdminMenu);
            this.Name = "FrmPrincipalAdministrador";
            this.Text = "Menu Administrador(a)";
            this.Load += new System.EventHandler(this.FrmPrincipalAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminMenu;
        private System.Windows.Forms.Button btnSaludMenu;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnSecretaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnEnfermera;
    }
}

