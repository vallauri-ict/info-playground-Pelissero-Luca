using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_023_ClasseAstratta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            ElencoStudenti elStud = new ElencoStudenti();
            elStud.print();
            MessageBox.Show(elStud.stampa);
        }
    }
}
