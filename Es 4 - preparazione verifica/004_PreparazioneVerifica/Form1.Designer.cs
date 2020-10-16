namespace _004_PreparazioneVerifica
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.figliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInviaFormFiglia = new System.Windows.Forms.TextBox();
            this.btnInviaAFormFiglia = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.newToolStripMenuItem3,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.menuToolStripMenuItem.Text = "&Menu File";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // newToolStripMenuItem3
            // 
            this.newToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figliaToolStripMenuItem,
            this.secondariaToolStripMenuItem,
            this.MDIToolStripMenuItem});
            this.newToolStripMenuItem3.Name = "newToolStripMenuItem3";
            this.newToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem3.Text = "New";
            // 
            // figliaToolStripMenuItem
            // 
            this.figliaToolStripMenuItem.Name = "figliaToolStripMenuItem";
            this.figliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figliaToolStripMenuItem.Text = "Figlia";
            this.figliaToolStripMenuItem.Click += new System.EventHandler(this.figliaToolStripMenuItem_Click);
            // 
            // secondariaToolStripMenuItem
            // 
            this.secondariaToolStripMenuItem.Name = "secondariaToolStripMenuItem";
            this.secondariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondariaToolStripMenuItem.Text = "Secondaria";
            this.secondariaToolStripMenuItem.Click += new System.EventHandler(this.secondariaToolStripMenuItem_Click);
            // 
            // MDIToolStripMenuItem
            // 
            this.MDIToolStripMenuItem.Name = "MDIToolStripMenuItem";
            this.MDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MDIToolStripMenuItem.Text = "MDI";
            this.MDIToolStripMenuItem.Click += new System.EventHandler(this.MDIToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(76, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(62, 70);
            this.txtEta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(76, 20);
            this.txtEta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Età";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txtInviaFormFiglia
            // 
            this.txtInviaFormFiglia.Location = new System.Drawing.Point(392, 68);
            this.txtInviaFormFiglia.Margin = new System.Windows.Forms.Padding(2);
            this.txtInviaFormFiglia.Name = "txtInviaFormFiglia";
            this.txtInviaFormFiglia.Size = new System.Drawing.Size(76, 20);
            this.txtInviaFormFiglia.TabIndex = 8;
            // 
            // btnInviaAFormFiglia
            // 
            this.btnInviaAFormFiglia.Location = new System.Drawing.Point(379, 40);
            this.btnInviaAFormFiglia.Margin = new System.Windows.Forms.Padding(2);
            this.btnInviaAFormFiglia.Name = "btnInviaAFormFiglia";
            this.btnInviaAFormFiglia.Size = new System.Drawing.Size(107, 19);
            this.btnInviaAFormFiglia.TabIndex = 9;
            this.btnInviaAFormFiglia.Text = "Invia A form Filgia";
            this.btnInviaAFormFiglia.UseVisualStyleBackColor = true;
            this.btnInviaAFormFiglia.Click += new System.EventHandler(this.btnInviaAFormFiglia_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLbl.Text = "Hello World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnInviaAFormFiglia);
            this.Controls.Add(this.txtInviaFormFiglia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem figliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInviaFormFiglia;
        private System.Windows.Forms.Button btnInviaAFormFiglia;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
    }
}

