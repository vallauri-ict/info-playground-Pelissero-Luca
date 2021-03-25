namespace Pelissero_Luca
{
    partial class ModalScelte
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.bntOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(406, 17);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Per poter andare avanti, prima effettua le scelte nella finestra 1";
            // 
            // bntOk
            // 
            this.bntOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntOk.Location = new System.Drawing.Point(151, 69);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(84, 31);
            this.bntOk.TabIndex = 1;
            this.bntOk.Text = "OK";
            this.bntOk.UseVisualStyleBackColor = true;
            // 
            // ModalScelte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 126);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.lblInfo);
            this.Name = "ModalScelte";
            this.Text = "ModalScelte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button bntOk;
    }
}