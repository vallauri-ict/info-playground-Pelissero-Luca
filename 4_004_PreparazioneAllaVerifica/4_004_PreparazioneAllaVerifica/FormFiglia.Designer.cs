namespace _4_004_PreparazioneAllaVerifica
{
    partial class FormFiglia
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
            this.txtStringaFiglia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInviaStringa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStringaFiglia
            // 
            this.txtStringaFiglia.Location = new System.Drawing.Point(66, 29);
            this.txtStringaFiglia.Name = "txtStringaFiglia";
            this.txtStringaFiglia.Size = new System.Drawing.Size(100, 20);
            this.txtStringaFiglia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stringa:";
            // 
            // btnInviaStringa
            // 
            this.btnInviaStringa.Location = new System.Drawing.Point(57, 55);
            this.btnInviaStringa.Name = "btnInviaStringa";
            this.btnInviaStringa.Size = new System.Drawing.Size(75, 23);
            this.btnInviaStringa.TabIndex = 2;
            this.btnInviaStringa.Text = "Invia";
            this.btnInviaStringa.UseVisualStyleBackColor = true;
            this.btnInviaStringa.Click += new System.EventHandler(this.btnInviaStringa_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 106);
            this.Controls.Add(this.btnInviaStringa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStringaFiglia);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStringaFiglia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInviaStringa;
    }
}