using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelissero_Luca
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string pathFile = Application.StartupPath + "\\salvataggio.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            creaButton();
        }

        private void creaButton()
        {
            int posY = 310;
            int posX = 10;
            int numEs = 3;

            for (int i = 0; i < 6; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Height = 20;
                btn.Width = 50;
                btn.Left = posX;
                btn.Top = posY;
                if (i == 5)
                    btn.Text = "FAC";
                else
                    btn.Text = "Parte " + numEs++;
                btn.AccessibleName = btn.Text;
                btn.Click += Button_Click;
                this.Controls.Add(btn);
                posX += 60;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.AccessibleName)
            {
                case "Parte 3":
                    parte3();
                    break;
                case "Parte 4":
                    parte4();
                    break;
                case "Parte 5":
                    parte5();
                    break;
                case "Parte 6":
                    parte6();
                    break;
                case "Parte 7":
                    parte7();
                    break;
                case "FAC":
                    facoltativo();
                    break;
            }
        }

        private void facoltativo()
        {
            
        }

        private void parte7()
        {
            StreamReader sr = new StreamReader(pathFile);
            MessageBox.Show(sr.ReadLine() + "\n" + sr.ReadLine());
            sr.Close();
        }

        private void parte6()
        {
            StreamWriter sw = new StreamWriter(pathFile);
            sw.WriteLine("Pelissero Luca");
            sw.WriteLine(DateTime.Now);
            sw.Close();
            
        }

        private void parte5()
        {
            saveFileDialogMain.Filter = "(*.txt)| *.*";
            saveFileDialogMain.FileName = "prova";

            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialogMain.FileName);
            }
        }

        private void parte4()
        {
            openFileDialogMain.Filter = "(*.txt)| *.*";
 ;
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialogMain.FileName);
            }
        }

        private void parte3()
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", "Attenzione", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1.ActiveForm.Close();
            }
        }
    }
}
