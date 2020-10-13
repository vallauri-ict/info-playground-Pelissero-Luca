namespace Es_3___FormMDI_con_funzionalità_es_1
{
    partial class Form2b
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
            this.btnApriFiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApriFiglia
            // 
            this.btnApriFiglia.Location = new System.Drawing.Point(74, 68);
            this.btnApriFiglia.Name = "btnApriFiglia";
            this.btnApriFiglia.Size = new System.Drawing.Size(168, 39);
            this.btnApriFiglia.TabIndex = 0;
            this.btnApriFiglia.Text = "Apri form figlia";
            this.btnApriFiglia.UseVisualStyleBackColor = true;
            this.btnApriFiglia.Click += new System.EventHandler(this.btnApriFiglia_Click);
            // 
            // Form2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 191);
            this.Controls.Add(this.btnApriFiglia);
            this.Name = "Form2b";
            this.Text = "Form2b";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApriFiglia;
    }
}