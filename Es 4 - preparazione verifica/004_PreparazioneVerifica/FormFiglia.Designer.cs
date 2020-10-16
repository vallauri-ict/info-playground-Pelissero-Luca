namespace _004_PreparazioneVerifica
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
            this.btnInviaFormPadre = new System.Windows.Forms.Button();
            this.txtInviaAFormPadre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInviaFormPadre
            // 
            this.btnInviaFormPadre.Location = new System.Drawing.Point(83, 63);
            this.btnInviaFormPadre.Margin = new System.Windows.Forms.Padding(2);
            this.btnInviaFormPadre.Name = "btnInviaFormPadre";
            this.btnInviaFormPadre.Size = new System.Drawing.Size(56, 19);
            this.btnInviaFormPadre.TabIndex = 0;
            this.btnInviaFormPadre.Text = "Invia Form Padre";
            this.btnInviaFormPadre.UseVisualStyleBackColor = true;
            this.btnInviaFormPadre.Click += new System.EventHandler(this.btnInviaFormPadre_Click);
            // 
            // txtInviaAFormPadre
            // 
            this.txtInviaAFormPadre.Location = new System.Drawing.Point(74, 32);
            this.txtInviaAFormPadre.Margin = new System.Windows.Forms.Padding(2);
            this.txtInviaAFormPadre.Name = "txtInviaAFormPadre";
            this.txtInviaAFormPadre.Size = new System.Drawing.Size(76, 20);
            this.txtInviaAFormPadre.TabIndex = 1;
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 165);
            this.Controls.Add(this.txtInviaAFormPadre);
            this.Controls.Add(this.btnInviaFormPadre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.Load += new System.EventHandler(this.FormFiglia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInviaFormPadre;
        private System.Windows.Forms.TextBox txtInviaAFormPadre;
    }
}