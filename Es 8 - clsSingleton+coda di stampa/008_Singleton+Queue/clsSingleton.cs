using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Singleton_Queue
{
    class clsSingleton
    {
        private static clsSingleton _instace = null;
        public static Queue<string> codaStampa = new Queue<string>();

        private clsSingleton()
        {

        }

        public void add (string s)
        {
            codaStampa.Enqueue(s);
            System.Windows.Forms.MessageBox.Show(s + " aggiunto alla coda");
        }

        public void stampa ()
        {
            try
            {
                string s = codaStampa.Dequeue();
                System.Windows.Forms.MessageBox.Show(s);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Coda vuota");
            }
        }

        public static clsSingleton GetClsSingleton()
        {
            if (_instace == null)
            {
                _instace = new clsSingleton();
            }
            return _instace;
        }
    }
}
