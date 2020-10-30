using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_004_PreparazioneAllaVerifica
{
    public partial class FormFiglia : Form
    {
        private TextBox txtPadre;
        private string txtValue;

        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();//da aggiungere sempre quando creo costruttore
            this.txtPadre = txtPadre;
        }

        //property
        public string TxtValue
        {
            get => txtValue;
            set {
                if (value != "")
                {
                    txtValue = value;
                    txtStringaFiglia.Text = txtValue;
                }
                else
                {
                    throw new Exception("Compilare il campo");
                }
            }
        }

        public FormFiglia()
        {
            InitializeComponent();

        }

        private void btnInviaStringa_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtStringaFiglia.Text;
        }
    }
}
