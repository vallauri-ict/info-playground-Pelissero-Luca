
namespace _4_028_Interfaccia_Comparable
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
            this.btnOrdMostra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdMostra
            // 
            this.btnOrdMostra.Location = new System.Drawing.Point(12, 12);
            this.btnOrdMostra.Name = "btnOrdMostra";
            this.btnOrdMostra.Size = new System.Drawing.Size(138, 33);
            this.btnOrdMostra.TabIndex = 0;
            this.btnOrdMostra.Text = "Ordina e Mostra";
            this.btnOrdMostra.UseVisualStyleBackColor = true;
            this.btnOrdMostra.Click += new System.EventHandler(this.btnOrdMostra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 53);
            this.Controls.Add(this.btnOrdMostra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdMostra;
    }
}

