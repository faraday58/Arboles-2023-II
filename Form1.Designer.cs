namespace Arboles_2023_II
{
    partial class Form1
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
            this.txtbDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbArbol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbDato
            // 
            this.txtbDato.Location = new System.Drawing.Point(198, 52);
            this.txtbDato.Name = "txtbDato";
            this.txtbDato.Size = new System.Drawing.Size(350, 20);
            this.txtbDato.TabIndex = 0;
            this.txtbDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDato_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa dato";
            // 
            // ptbArbol
            // 
            this.ptbArbol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptbArbol.Location = new System.Drawing.Point(65, 120);
            this.ptbArbol.Name = "ptbArbol";
            this.ptbArbol.Size = new System.Drawing.Size(864, 394);
            this.ptbArbol.TabIndex = 2;
            this.ptbArbol.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 542);
            this.Controls.Add(this.ptbArbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDato);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbArbol;
    }
}

