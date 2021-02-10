using System;
using System.Windows.Forms;

namespace _4_028_Interfaccia_Comparable
{
    public partial class Form1 : Form
    {
        Persona[] vect = { new Persona("Luca", "Bonelli", "Fossano"),
                            new Persona("Antonio", "Ariaudo", "Alba"),
                            new Persona("Samuele", "Stefirca", "Savigliano")};

        public Form1()
        {
            InitializeComponent();
            ShowPerson();
        }

        public void ShowPerson()
        {
            string s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnOrdMostra_Click(object sender, System.EventArgs e)
        {
            Array.Sort(vect);
            ShowPerson();
        }
    }
}
