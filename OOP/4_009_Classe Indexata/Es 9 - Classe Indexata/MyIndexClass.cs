using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Es_9___Classe_Indexata
{
    class MyIndexClass
    {
        private string[] element;

        public MyIndexClass(int elementNumber)
        {
            element = new string[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                element[i] = "empty";
            }
        }

        // Iteratore
        // è un metodo che restituisce una stringa. 
        public string this[int pos]
        {
            get { return element[pos]; } //ritona il valore
            set { element[pos] = value; } //imposta il valore
        }

        public int lenght()
        {
            return element.Length;
        }
    }
}
