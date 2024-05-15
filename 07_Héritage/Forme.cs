using System;

namespace _07_Héritage
{
    // Classe parente qui fait hériter ses membres aux classes dérivées
    internal class Forme
    {
        protected string _Couleur;

        public string Couleur
        {
            // => Remplace return
            get => _Couleur;
            set => _Couleur = value;
        }

        // Virtual : Permet la redéfinition de la méthode dans les classes enfants
        public virtual void Dessine()
        {
            Console.WriteLine("Dessine la forme ");
        }
    }
}
