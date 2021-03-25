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
    public partial class FormMdiParent : Form
    {
        public FormMdiParent()
        {
            InitializeComponent();
        }

        private void btnCreaChildren_Click(object sender, EventArgs e)
        {
            Point startPoint = new Point(0, 100);
            foreach (var item in this.MdiChildren)
            {
                startPoint.X += item.Width + 10;
            }
            FormMdi fm = new FormMdi();
            fm.MdiParent = this;
            fm.Width = 100;
            fm.Height = 100;
            fm.StartPosition = FormStartPosition.Manual;
            fm.Location = startPoint;
            fm.Show();
        }
    }
}
