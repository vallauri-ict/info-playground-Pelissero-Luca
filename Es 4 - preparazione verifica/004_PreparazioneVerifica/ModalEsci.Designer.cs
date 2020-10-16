namespace _004_PreparazioneVerifica
{
    partial class ModalEsci
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
            this.btnEsciAnnulla = new System.Windows.Forms.Button();
            this.btnEsciOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEsciAnnulla
            // 
            this.btnEsciAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsciAnnulla.Location = new System.Drawing.Point(193, 54);
            this.btnEsciAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnEsciAnnulla.Name = "btnEsciAnnulla";
            this.btnEsciAnnulla.Size = new System.Drawing.Size(100, 28);
            this.btnEsciAnnulla.TabIndex = 5;
            this.btnEsciAnnulla.Text = "Annulla";
            this.btnEsciAnnulla.UseVisualStyleBackColor = true;
            // 
            // btnEsciOK
            // 
            this.btnEsciOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEsciOK.Location = new System.Drawing.Point(65, 54);
            this.btnEsciOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnEsciOK.Name = "btnEsciOK";
            this.btnEsciOK.Size = new System.Drawing.Size(100, 28);
            this.btnEsciOK.TabIndex = 4;
            this.btnEsciOK.Text = "OK";
            this.btnEsciOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vuoi uscire?";
            // 
            // ModalEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 118);
            this.Controls.Add(this.btnEsciAnnulla);
            this.Controls.Add(this.btnEsciOK);
            this.Controls.Add(this.label1);
            this.Name = "ModalEsci";
            this.Text = "ModalEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsciAnnulla;
        private System.Windows.Forms.Button btnEsciOK;
        private System.Windows.Forms.Label label1;
    }
}