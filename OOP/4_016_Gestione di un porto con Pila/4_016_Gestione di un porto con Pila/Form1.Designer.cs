
namespace _4_016_Gestione_di_un_porto_con_Pila
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.bntPop = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codice Conteiner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tara";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(149, 23);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 22);
            this.txtCod.TabIndex = 4;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(149, 51);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 5;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(149, 79);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(100, 22);
            this.txtTara.TabIndex = 6;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(30, 116);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(219, 31);
            this.btnPush.TabIndex = 7;
            this.btnPush.Text = "Carica Container";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // bntPop
            // 
            this.bntPop.Location = new System.Drawing.Point(291, 23);
            this.bntPop.Name = "bntPop";
            this.bntPop.Size = new System.Drawing.Size(171, 31);
            this.bntPop.TabIndex = 8;
            this.bntPop.Text = "Scarica Container";
            this.bntPop.UseVisualStyleBackColor = true;
            this.bntPop.Click += new System.EventHandler(this.bntPop_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(288, 65);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(118, 20);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Info Container:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 169);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.bntPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button bntPop;
        private System.Windows.Forms.Label lblInfo;
    }
}

