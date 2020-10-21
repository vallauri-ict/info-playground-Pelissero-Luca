using System;
using System.Drawing;
using System.Windows.Forms;

namespace Es_5___oop01
{
    public partial class Form1 : Form
    {
        Rectangle r;

        public Form1()
        {
            InitializeComponent();
            //r = new Rectangle();
        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            //r.side1 = Convert.ToInt32(txtBase.Text);
            //r.side2 = Convert.ToInt32(txtAltezza.Text);
            //Rectangle t;
            //t = r;
            //MessageBox.Show("Base: "+r.side1+"\nAltezza: "+r.side2);
            //MessageBox.Show("Per l'oggetto t\nBase: "+t.side1+"\nAltezza: "+t.side2);
            //t.side1 = 10;
            //MessageBox.Show("Oggetto r dopo modifiche su t\nBase: " + r.side1 + "\nAltezza: " + r.side2);
            r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            r.color = Color.White;
            MessageBox.Show(r.getSide());
        }
    }
}
