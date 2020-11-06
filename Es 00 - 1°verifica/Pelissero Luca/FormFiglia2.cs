using System.Windows.Forms;

namespace Pelissero_Luca
{
    public partial class FormFiglia2 : Form
    {
        public FormFiglia2()
        {
            InitializeComponent();
        }

        public FormFiglia2(string pelle, string stoffa, string marchio)
        {
            InitializeComponent();
            lblInfo.Text = "Hai selezionato una " + marchio + " con interni in " + pelle + ", " + stoffa;
        }
    }
}
