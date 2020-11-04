namespace Es_9___Classe_Indexata
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.txtElementi = new System.Windows.Forms.TextBox();
            this.bntVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(30, 49);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(103, 29);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea Classe";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // txtElementi
            // 
            this.txtElementi.Location = new System.Drawing.Point(30, 12);
            this.txtElementi.Name = "txtElementi";
            this.txtElementi.Size = new System.Drawing.Size(103, 22);
            this.txtElementi.TabIndex = 1;
            // 
            // bntVisualizza
            // 
            this.bntVisualizza.Location = new System.Drawing.Point(30, 84);
            this.bntVisualizza.Name = "bntVisualizza";
            this.bntVisualizza.Size = new System.Drawing.Size(103, 29);
            this.bntVisualizza.TabIndex = 2;
            this.bntVisualizza.Text = "Visualizza";
            this.bntVisualizza.UseVisualStyleBackColor = true;
            this.bntVisualizza.Click += new System.EventHandler(this.bntVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 257);
            this.Controls.Add(this.bntVisualizza);
            this.Controls.Add(this.txtElementi);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.TextBox txtElementi;
        private System.Windows.Forms.Button bntVisualizza;
    }
}

