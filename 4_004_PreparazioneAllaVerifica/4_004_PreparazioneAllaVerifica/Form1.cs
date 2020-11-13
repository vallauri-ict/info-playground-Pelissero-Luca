using System;
using System.Windows.Forms;

namespace _4_004_PreparazioneAllaVerifica
{
    public partial class formMain : Form
    {
        public FormFiglia ff;

        public formMain()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "File/Load";
            loadBar();

        }

        private void loadBar()
        {
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Value = 0;

            }
            toolStripProgressBar1.Value = 100;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "File/Save";
            loadBar();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExit fe = new FormExit();
            if (fe.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "File/UscitaAnnullata";
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtNome, txtEta);
            if (f2.ShowDialog() == DialogResult.OK)//showDialog aspetta finisca f2
            {
                MessageBox.Show("Nome:" + f2.nome + "\nEtà:" + f2.eta);
                txtEta.Text = f2.eta;
                txtNome.Text = f2.nome;
                toolStripStatusLabel1.Text = "File/ApriForm2/Ok";
            }
            else
            {
                MessageBox.Show("Operazione annullata");
                toolStripStatusLabel1.Text = "File/ApriForm2/Annulla";
            }
        }

        private void formDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fd = new Form();
            fd.Show();
            fd.Text = "Form dinamica";
            toolStripStatusLabel1.Text = "File/ApriFormDinamica";
        }

        private void formFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //passo la txt alla form figlia
            ff = new FormFiglia(txtStringa);
            this.AddOwnedForm(ff);
            ff.Show();
            toolStripStatusLabel1.Text = "File/ApriFormFiglia";
        }

        private void formMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMdiParent fmp = new FormMdiParent();
            fmp.Show();
            toolStripStatusLabel1.Text = "File/FormMDI";
        }

        private void btnInviaStringa_Click(object sender, EventArgs e)
        {
            try
            {
                ff.TxtValue = txtStringa.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Racca Paolo ©\nProject finished on 16/10/2020", "?");
            toolStripStatusLabel1.Text = "?";
        }
    }
}
