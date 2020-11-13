namespace Multiform01
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
            this.btnAproF2 = new System.Windows.Forms.Button();
            this.btnApriF2b = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.txtEtaFm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeFm = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAproF2
            // 
            this.btnAproF2.Location = new System.Drawing.Point(63, 30);
            this.btnAproF2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAproF2.Name = "btnAproF2";
            this.btnAproF2.Size = new System.Drawing.Size(100, 28);
            this.btnAproF2.TabIndex = 0;
            this.btnAproF2.Text = "Apri Form 2";
            this.btnAproF2.UseVisualStyleBackColor = true;
            this.btnAproF2.Click += new System.EventHandler(this.btnApriF2_Click);
            // 
            // btnApriF2b
            // 
            this.btnApriF2b.Location = new System.Drawing.Point(221, 30);
            this.btnApriF2b.Margin = new System.Windows.Forms.Padding(4);
            this.btnApriF2b.Name = "btnApriF2b";
            this.btnApriF2b.Size = new System.Drawing.Size(100, 28);
            this.btnApriF2b.TabIndex = 1;
            this.btnApriF2b.Text = "Apri Form 2b";
            this.btnApriF2b.UseVisualStyleBackColor = true;
            this.btnApriF2b.Click += new System.EventHandler(this.btnApriF2b_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(63, 82);
            this.txtPassata.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(132, 22);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(204, 82);
            this.btnPassaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(161, 28);
            this.btnPassaTxt.TabIndex = 3;
            this.btnPassaTxt.Text = "Passa TXT a F2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(63, 193);
            this.btnFormModale.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(161, 28);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "Apri form con modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // txtEtaFm
            // 
            this.txtEtaFm.Location = new System.Drawing.Point(321, 145);
            this.txtEtaFm.Margin = new System.Windows.Forms.Padding(4);
            this.txtEtaFm.Name = "txtEtaFm";
            this.txtEtaFm.ReadOnly = true;
            this.txtEtaFm.Size = new System.Drawing.Size(132, 22);
            this.txtEtaFm.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Età";
            // 
            // txtNomeFm
            // 
            this.txtNomeFm.Location = new System.Drawing.Point(119, 145);
            this.txtNomeFm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFm.Name = "txtNomeFm";
            this.txtNomeFm.ReadOnly = true;
            this.txtNomeFm.Size = new System.Drawing.Size(132, 22);
            this.txtNomeFm.TabIndex = 9;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(67, 145);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 17);
            this.Nome.TabIndex = 8;
            this.Nome.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtEtaFm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeFm);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnApriF2b);
            this.Controls.Add(this.btnAproF2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAproF2;
        private System.Windows.Forms.Button btnApriF2b;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.Button btnFormModale;
        private System.Windows.Forms.TextBox txtEtaFm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeFm;
        private System.Windows.Forms.Label Nome;
    }
}

