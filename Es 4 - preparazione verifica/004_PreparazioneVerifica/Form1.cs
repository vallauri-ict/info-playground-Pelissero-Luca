using System;
using System.Windows.Forms;

namespace _004_PreparazioneVerifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire";
            toolStripStatusLbl.Text = "Premuto tasto uscita";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        private void secondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecondaria f = new FormSecondaria(txtNome, txtEta);
            toolStripStatusLbl.Text = "Aperta Form Secondaria";
            f.Show();
        }

        FormFiglia ff;
        private void btnInviaAFormFiglia_Click(object sender, EventArgs e)
        {
            if (((FormFiglia)Application.OpenForms["FormFiglia"])!=null)
            {
                ff.txtF1.Text = txtInviaFormFiglia.Text;
            }
            else
            {
                figliaToolStripMenuItem_Click(sender, e);
                ff.txtF1.Text = txtInviaFormFiglia.Text;
            }
        }
        
        private void figliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ff = new FormFiglia(txtInviaFormFiglia);
            toolStripStatusLbl.Text = "Aperta Form secondaria";
            this.AddOwnedForm(ff);
            ff.Show();
        }

        private void MDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDI fm = new FormMDI();
            fm.IsMdiContainer = true;
            fm.Show();
        }
    }
}
