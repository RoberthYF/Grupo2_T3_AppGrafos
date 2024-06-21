namespace Grupo2_T3_AppGrafos
{
    partial class FrmPrincipal
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnInteligente = new System.Windows.Forms.Button();
            this.btnRedes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(64, 114);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(156, 84);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Administrar Vuelos";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnInteligente
            // 
            this.btnInteligente.Location = new System.Drawing.Point(297, 114);
            this.btnInteligente.Name = "btnInteligente";
            this.btnInteligente.Size = new System.Drawing.Size(156, 84);
            this.btnInteligente.TabIndex = 1;
            this.btnInteligente.Text = "Vuelo Inteligente";
            this.btnInteligente.UseVisualStyleBackColor = true;
            this.btnInteligente.Click += new System.EventHandler(this.btnInteligente_Click);
            // 
            // btnRedes
            // 
            this.btnRedes.Location = new System.Drawing.Point(521, 114);
            this.btnRedes.Name = "btnRedes";
            this.btnRedes.Size = new System.Drawing.Size(156, 84);
            this.btnRedes.TabIndex = 2;
            this.btnRedes.Text = "Redes de vuelos";
            this.btnRedes.UseVisualStyleBackColor = true;
            this.btnRedes.Click += new System.EventHandler(this.btnRedes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 331);
            this.Controls.Add(this.btnRedes);
            this.Controls.Add(this.btnInteligente);
            this.Controls.Add(this.btnAdmin);
            this.Name = "FrmPrincipal";
            this.Text = "Aereolinea Grupo 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnInteligente;
        private System.Windows.Forms.Button btnRedes;
    }
}

