using System.Windows.Forms;

namespace _4_019_Ereditarietà03
{
    public class Mostro
    {
        public string nome;

        public Mostro() : this("Mostro")
        {

        }

        public Mostro(string nome)
        {
            this.nome = nome;
        }

        public void Rivela()
        {
            MessageBox.Show(nome);
        }
    }
}
