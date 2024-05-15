using System;

namespace _07_Héritage
{
    internal class Carre : Rectangle
    {

        public new void Dessine()
        {
            Console.WriteLine("Dessine le carré");
        }
    }
}
