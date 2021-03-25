using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_023_ClasseAstratta
{
    abstract class Report
    {
        protected abstract void printerHeader();
        protected abstract void printBody();
        protected abstract void printerFooter();

        public void print()
        {
            printerHeader();
            printBody();
            printerFooter();
        }
    }
}
