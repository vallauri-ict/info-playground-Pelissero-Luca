using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_11___RegEx_Form_di_Registrazione
{
    class clsUtenti
    {
        private static clsUtenti _instance;

        public void user(string s)
        {
            StreamWriter swUser = new StreamWriter("User.txt", true);
            swUser.WriteLine(s);
            swUser.Close();
        }

        public bool controllaUser(string user)
        {
            StreamReader srUser = new StreamReader("User.txt");
            string s;
            bool ok = true;

            while ((srUser.Peek() != -1) && (ok))
            {
                s = srUser.ReadLine();
                if (user == s) ok = false;
            }
            srUser.Close();

            if (ok == true)
                return true;
            else
                return false;
        }
    }
}
