using System;

namespace _08_Polymorphisme.Models
{
    internal class Vehicule
    {
        public virtual void SeDeplace()
        {
            Console.WriteLine("Je me déplace...");
        }
    }
}
