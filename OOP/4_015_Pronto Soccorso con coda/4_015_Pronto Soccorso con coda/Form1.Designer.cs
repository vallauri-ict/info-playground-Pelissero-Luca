namespace _4_015_Pronto_Soccorso_con_coda
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnVisita = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInfoPaziente = new System.Windows.Forms.Label();
            this.bntAddTemp = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrazione Paziente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Età";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Colore";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(91, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(138, 94);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(91, 22);
            this.txtEta.TabIndex = 5;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(138, 121);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(91, 22);
            this.txtColore.TabIndex = 6;
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(45, 179);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(184, 32);
            this.btnRegistra.TabIndex = 7;
            this.btnRegistra.Text = "Registra";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnVisita
            // 
            this.btnVisita.Location = new System.Drawing.Point(258, 66);
            this.btnVisita.Name = "btnVisita";
            this.btnVisita.Size = new System.Drawing.Size(151, 32);
            this.btnVisita.TabIndex = 8;
            this.btnVisita.Text = "Visita Paziente";
            this.btnVisita.UseVisualStyleBackColor = true;
            this.btnVisita.Click += new System.EventHandler(this.btnVisita_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Medico libero";
            // 
            // lblInfoPaziente
            // 
            this.lblInfoPaziente.AutoSize = true;
            this.lblInfoPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPaziente.Location = new System.Drawing.Point(255, 121);
            this.lblInfoPaziente.Name = "lblInfoPaziente";
            this.lblInfoPaziente.Size = new System.Drawing.Size(111, 20);
            this.lblInfoPaziente.TabIndex = 10;
            this.lblInfoPaziente.Text = "Info Paziente:";
            // 
            // bntAddTemp
            // 
            this.bntAddTemp.Location = new System.Drawing.Point(45, 217);
            this.bntAddTemp.Name = "bntAddTemp";
            this.bntAddTemp.Size = new System.Drawing.Size(184, 32);
            this.bntAddTemp.TabIndex = 15;
            this.bntAddTemp.Text = "Visualizza temperature";
            this.bntAddTemp.UseVisualStyleBackColor = true;
            this.bntAddTemp.Click += new System.EventHandler(this.bntAddTemp_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(138, 149);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(91, 22);
            this.txtTemperatura.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 263);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntAddTemp);
            this.Controls.Add(this.lblInfoPaziente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVisita);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnVisita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInfoPaziente;
        private System.Windows.Forms.Button bntAddTemp;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label6;
    }
}

