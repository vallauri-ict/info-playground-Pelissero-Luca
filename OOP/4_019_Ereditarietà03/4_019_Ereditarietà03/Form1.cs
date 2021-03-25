using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_019_Ereditarietà03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro();
            Mostro y; 
            y = Clona_V(x); 
            x.Rivela();
            y.Rivela();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro(); 
            Mostro y; 
            y = Clona_R(ref x); 
            x.Rivela(); 
            y.Rivela();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_O(out x);
            x.Rivela(); 
            y.Rivela();
        }

        public Mostro Clona_V(Mostro p)
        {
            p = new Mostro("Valuex");
            p.nome = "Cambia";
            return p;
        }

        public Mostro Clona_R(ref Mostro p)
        {
            p = new Mostro("Referx");
            p.nome = "Cambia";
            return p;
        }

        public Mostro Clona_O(out Mostro p)
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }
    }
}
