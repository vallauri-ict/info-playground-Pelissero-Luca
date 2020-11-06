namespace Pelissero_Luca
{
    partial class FormFiglia1
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
            this.chkPelle = new System.Windows.Forms.CheckBox();
            this.chkStoffa = new System.Windows.Forms.CheckBox();
            this.cmbMarchi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkPelle
            // 
            this.chkPelle.AutoSize = true;
            this.chkPelle.Location = new System.Drawing.Point(47, 40);
            this.chkPelle.Name = "chkPelle";
            this.chkPelle.Size = new System.Drawing.Size(119, 21);
            this.chkPelle.TabIndex = 0;
            this.chkPelle.Text = "Interni in Pelle";
            this.chkPelle.UseVisualStyleBackColor = true;
            this.chkPelle.CheckedChanged += new System.EventHandler(this.chkPelle_CheckedChanged);
            // 
            // chkStoffa
            // 
            this.chkStoffa.AutoSize = true;
            this.chkStoffa.Location = new System.Drawing.Point(47, 67);
            this.chkStoffa.Name = "chkStoffa";
            this.chkStoffa.Size = new System.Drawing.Size(125, 21);
            this.chkStoffa.TabIndex = 1;
            this.chkStoffa.Text = "Interni in Stoffa";
            this.chkStoffa.UseVisualStyleBackColor = true;
            this.chkStoffa.CheckedChanged += new System.EventHandler(this.chkStoffa_CheckedChanged);
            // 
            // cmbMarchi
            // 
            this.cmbMarchi.FormattingEnabled = true;
            this.cmbMarchi.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.cmbMarchi.Location = new System.Drawing.Point(45, 94);
            this.cmbMarchi.Name = "cmbMarchi";
            this.cmbMarchi.Size = new System.Drawing.Size(121, 24);
            this.cmbMarchi.TabIndex = 2;
            this.cmbMarchi.SelectedIndexChanged += new System.EventHandler(this.cmbMarchi_SelectedIndexChanged);
            // 
            // FormFiglia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 155);
            this.Controls.Add(this.cmbMarchi);
            this.Controls.Add(this.chkStoffa);
            this.Controls.Add(this.chkPelle);
            this.Name = "FormFiglia1";
            this.Text = "FormFiglia1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPelle;
        private System.Windows.Forms.CheckBox chkStoffa;
        private System.Windows.Forms.ComboBox cmbMarchi;
    }
}