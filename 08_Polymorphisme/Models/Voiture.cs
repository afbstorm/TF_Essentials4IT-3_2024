using System;

namespace _08_Polymorphisme.Models
{
    internal class Voiture : Vehicule
    {
        public override void SeDeplace()
        {
            base.SeDeplace();
            Console.WriteLine(" en voiture");
        }

        public void trucMuche()
        {
            Console.WriteLine("Hello la voiture");
        }
    }
}
