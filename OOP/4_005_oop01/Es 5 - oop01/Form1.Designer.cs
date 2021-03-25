namespace Es_5___oop01
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreaRettangolo = new System.Windows.Forms.Button();
            this.btnCreaFattura = new System.Windows.Forms.Button();
            this.btnNFattura = new System.Windows.Forms.Button();
            this.bntClasseStatica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(87, 54);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(87, 95);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 22);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altezza";
            // 
            // btnCreaRettangolo
            // 
            this.btnCreaRettangolo.Location = new System.Drawing.Point(60, 144);
            this.btnCreaRettangolo.Name = "btnCreaRettangolo";
            this.btnCreaRettangolo.Size = new System.Drawing.Size(83, 31);
            this.btnCreaRettangolo.TabIndex = 4;
            this.btnCreaRettangolo.Text = "Crea";
            this.btnCreaRettangolo.UseVisualStyleBackColor = true;
            this.btnCreaRettangolo.Click += new System.EventHandler(this.btnCreaRettangolo_Click);
            // 
            // btnCreaFattura
            // 
            this.btnCreaFattura.Location = new System.Drawing.Point(220, 37);
            this.btnCreaFattura.Name = "btnCreaFattura";
            this.btnCreaFattura.Size = new System.Drawing.Size(143, 34);
            this.btnCreaFattura.TabIndex = 5;
            this.btnCreaFattura.Text = "Crea fattura";
            this.btnCreaFattura.UseVisualStyleBackColor = true;
            this.btnCreaFattura.Click += new System.EventHandler(this.btnCreaFattura_Click);
            // 
            // btnNFattura
            // 
            this.btnNFattura.Location = new System.Drawing.Point(220, 77);
            this.btnNFattura.Name = "btnNFattura";
            this.btnNFattura.Size = new System.Drawing.Size(143, 31);
            this.btnNFattura.TabIndex = 6;
            this.btnNFattura.Text = "Numero di Fattura";
            this.btnNFattura.UseVisualStyleBackColor = true;
            this.btnNFattura.Click += new System.EventHandler(this.btnNFattura_Click);
            // 
            // bntClasseStatica
            // 
            this.bntClasseStatica.Location = new System.Drawing.Point(220, 114);
            this.bntClasseStatica.Name = "bntClasseStatica";
            this.bntClasseStatica.Size = new System.Drawing.Size(143, 31);
            this.bntClasseStatica.TabIndex = 7;
            this.bntClasseStatica.Text = "Classe Statica";
            this.bntClasseStatica.UseVisualStyleBackColor = true;
            this.bntClasseStatica.Click += new System.EventHandler(this.bntClasseStatica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 189);
            this.Controls.Add(this.bntClasseStatica);
            this.Controls.Add(this.btnNFattura);
            this.Controls.Add(this.btnCreaFattura);
            this.Controls.Add(this.btnCreaRettangolo);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreaRettangolo;
        private System.Windows.Forms.Button btnCreaFattura;
        private System.Windows.Forms.Button btnNFattura;
        private System.Windows.Forms.Button bntClasseStatica;
    }
}

