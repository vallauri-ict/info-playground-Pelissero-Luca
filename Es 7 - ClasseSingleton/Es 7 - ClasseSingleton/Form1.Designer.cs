namespace Es_7___ClasseSingleton
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.btnCraClasse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci un valore";
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(166, 29);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 22);
            this.txtValore.TabIndex = 1;
            // 
            // btnCraClasse
            // 
            this.btnCraClasse.Location = new System.Drawing.Point(93, 74);
            this.btnCraClasse.Name = "btnCraClasse";
            this.btnCraClasse.Size = new System.Drawing.Size(119, 33);
            this.btnCraClasse.TabIndex = 2;
            this.btnCraClasse.Text = "Crea Classe";
            this.btnCraClasse.UseVisualStyleBackColor = true;
            this.btnCraClasse.Click += new System.EventHandler(this.btnCraClasse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 131);
            this.Controls.Add(this.btnCraClasse);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.Button btnCraClasse;
    }
}

