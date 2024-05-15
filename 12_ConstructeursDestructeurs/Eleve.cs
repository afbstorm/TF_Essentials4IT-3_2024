using System;

namespace _12_ConstructeursDestructeurs
{
    internal class Eleve : Personne
    {
        public string Matricule { get; set; }

        public Eleve()
        {
            
        }

        public Eleve(string matricule, string nom, string prenom) :base(nom, prenom)
        {
            Matricule = matricule;
        }

        public Eleve(string matricule, string nom, string prenom, DateTime dateNaissance, double taille, double poids) 
            :base(nom, prenom, dateNaissance, taille, poids)
        {
            Matricule = matricule;
        }

        // Déclaration du destructeur
        ~Eleve()
        {
            Console.WriteLine("---- Instance d'élève détruite ! ---- ");
        }

        public override string ToString()
        {
            return $"{Matricule}";
        }
    }
}
