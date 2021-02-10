using System.Windows.Forms;

namespace _4_027__interfacce
{
    class MyComponent : IDispAggiuntivo
    {
        private int _id;
        private bool _status;

        public int id { get => _id; set => _id = value; }

        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            MessageBox.Show("Connesso a: " + s);
        }

        public void disconnetti(string s)
        {
            _status = false;
            _id++;
            MessageBox.Show("Disconnesso a: " + s);
        }

        public void stato()
        {
            if (status)
            {
                MessageBox.Show("Attualmente Connesso con id: "+id);
            }
            else
            {
                MessageBox.Show("Non Connesso");
            }
        }
    }
}
