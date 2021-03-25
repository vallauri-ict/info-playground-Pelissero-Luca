namespace _4_004_PreparazioneAllaVerifica
{
    partial class FormMdiParent
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
            this.btnCreaChildren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaChildren
            // 
            this.btnCreaChildren.Location = new System.Drawing.Point(190, 12);
            this.btnCreaChildren.Name = "btnCreaChildren";
            this.btnCreaChildren.Size = new System.Drawing.Size(225, 57);
            this.btnCreaChildren.TabIndex = 0;
            this.btnCreaChildren.Text = "Crea Form Mdi Children";
            this.btnCreaChildren.UseVisualStyleBackColor = true;
            this.btnCreaChildren.Click += new System.EventHandler(this.btnCreaChildren_Click);
            // 
            // FormMdiParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 472);
            this.Controls.Add(this.btnCreaChildren);
            this.IsMdiContainer = true;
            this.Name = "FormMdiParent";
            this.Text = "formMdiParent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaChildren;
    }
}