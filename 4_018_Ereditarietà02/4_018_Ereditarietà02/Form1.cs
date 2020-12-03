using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4_018_Ereditarietà02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button) 
                (sender as Button).Text = "hello"; 
            if (sender is Label) 
                (sender as Label).BackColor = Color.Red;
        }
    }
}
