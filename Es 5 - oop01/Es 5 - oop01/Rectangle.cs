using System.Drawing;

namespace Es_5___oop01
{
    class Rectangle
    {
        //lati del rettangolo
        private int side1, side2;
        private string descrizione;
        public Color color;

        public Rectangle()
        {
            descrizione = "Sono un rettangolo";
        }

        public Rectangle(int baseRettangolo, int altezzaRettangolo)
        {
            side1 = baseRettangolo;
            side2 = altezzaRettangolo;
        }

        public string getSide()
        {
            return "Base: " + side1.ToString() + "\nAltezza: " + side2.ToString();
        }
    }
}
