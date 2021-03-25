namespace _4_014_Dictionary_Negozio
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVis = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNArt = new System.Windows.Forms.Label();
            this.lblRicerca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Articolo";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(107, 49);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(107, 95);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Inserisci";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVis
            // 
            this.btnVis.Location = new System.Drawing.Point(36, 189);
            this.btnVis.Name = "btnVis";
            this.btnVis.Size = new System.Drawing.Size(171, 31);
            this.btnVis.TabIndex = 5;
            this.btnVis.Text = "Visualizza";
            this.btnVis.UseVisualStyleBackColor = true;
            this.btnVis.Click += new System.EventHandler(this.btnVis_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(36, 226);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(171, 31);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lblNArt
            // 
            this.lblNArt.AutoSize = true;
            this.lblNArt.Location = new System.Drawing.Point(228, 196);
            this.lblNArt.Name = "lblNArt";
            this.lblNArt.Size = new System.Drawing.Size(127, 17);
            this.lblNArt.TabIndex = 7;
            this.lblNArt.Text = "Numero articoli = 0";
            // 
            // lblRicerca
            // 
            this.lblRicerca.AutoSize = true;
            this.lblRicerca.Location = new System.Drawing.Point(228, 233);
            this.lblRicerca.Name = "lblRicerca";
            this.lblRicerca.Size = new System.Drawing.Size(134, 17);
            this.lblRicerca.TabIndex = 8;
            this.lblRicerca.Text = "Articolo ricercato = .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 282);
            this.Controls.Add(this.lblRicerca);
            this.Controls.Add(this.lblNArt);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.btnVis);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVis;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNArt;
        private System.Windows.Forms.Label lblRicerca;
    }
}

