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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.menuToolStripMenuItem.Text = "&Menu File";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // newToolStripMenuItem3
            // 
            this.newToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figliaToolStripMenuItem,
            this.secondariaToolStripMenuItem,
            this.MDIToolStripMenuItem});
            this.newToolStripMenuItem3.Name = "newToolStripMenuItem3";
            this.newToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem3.Text = "New";
            // 
            // figliaToolStripMenuItem
            // 
            this.figliaToolStripMenuItem.Name = "figliaToolStripMenuItem";
            this.figliaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.figliaToolStripMenuItem.Text = "Figlia";
            this.figliaToolStripMenuItem.Click += new System.EventHandler(this.figliaToolStripMenuItem_Click);
            // 
            // secondariaToolStripMenuItem
            // 
            this.secondariaToolStripMenuItem.Name = "secondariaToolStripMenuItem";
            this.secondariaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.secondariaToolStripMenuItem.Text = "Secondaria";
            this.secondariaToolStripMenuItem.Click += new System.EventHandler(this.secondariaToolStripMenuItem_Click);
            // 
            // MDIToolStripMenuItem
            // 
            this.MDIToolStripMenuItem.Name = "MDIToolStripMenuItem";
            this.MDIToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.MDIToolStripMenuItem.Text = "MDI";
            this.MDIToolStripMenuItem.Click += new System.EventHandler(this.MDIToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(83, 50);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 7;
            // 
            // txtEta
            // 
            this.txtEta.Enabled = false;
            this.txtEta.Location = new System.Drawing.Point(83, 86);
            this.txtEta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 22);
            this.txtEta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Età";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txtInviaFormFiglia
            // 
            this.txtInviaFormFiglia.Location = new System.Drawing.Point(523, 84);
            this.txtInviaFormFiglia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInviaFormFiglia.Name = "txtInviaFormFiglia";
            this.txtInviaFormFiglia.Size = new System.Drawing.Size(100, 22);
            this.txtInviaFormFiglia.TabIndex = 8;
            // 
            // btnInviaAFormFiglia
            // 
            this.btnInviaAFormFiglia.Location = new System.Drawing.Point(505, 49);
            this.btnInviaAFormFiglia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInviaAFormFiglia.Name = "btnInviaAFormFiglia";
            this.btnInviaAFormFiglia.Size = new System.Drawing.Size(143, 23);
            this.btnInviaAFormFiglia.TabIndex = 9;
            this.btnInviaAFormFiglia.Text = "Invia A form Filgia";
            this.btnInviaAFormFiglia.UseVisualStyleBackColor = true;
            this.btnInviaAFormFiglia.Click += new System.EventHandler(this.btnInviaAFormFiglia_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(89, 20);
            this.toolStripStatusLbl.Text = "Hello World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnInviaAFormFiglia);
            this.Controls.Add(this.txtInviaFormFiglia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

