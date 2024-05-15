using System;

namespace _07_Héritage
{
    // Classe enfant, dérivée, sous-classe
    // sealed = Empêche l'héritage de la classe
    // sealed
    internal class Rectangle : Forme
    {
        public double Largeur { get; set; }
        public double Longueur {  get; set; }

        public override void Dessine()
        {
            base.Dessine();
            Console.WriteLine("qui est un rectangle");
        }
    }
}
