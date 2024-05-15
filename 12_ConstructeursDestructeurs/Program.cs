using System;

namespace _12_ConstructeursDestructeurs;

internal class Program
{
    private static void Main(string[] args)
    {

        //Personne Formateur = new Personne();
        //Console.WriteLine(Formateur);

        //Personne FanDuStandard = new Personne("Bouvier", "Cédric", new DateTime(1980,12, 22), 173, 103);
        //Console.WriteLine(FanDuStandard);

        //Personne FanDeOnePiece = new Personne("Scorniciel", "Ayrton");
        //Console.WriteLine(FanDeOnePiece);

        //Eleve Manuel = new Eleve("J007", "Randour", "Manuel", new DateTime(1984,6,12), 180, 78);
        //Console.WriteLine(Manuel);

        Console.WriteLine(" ---- Début du spam et du nettoyage par Garbage Collector ---- ");

        for (int i = 0; i < 20000; i++)
        {
            Eleve eleve = new Eleve("L042", "Freyling", "Aurélien", DateTime.Now, 188, 91);
            Console.WriteLine($"Eleve: {eleve}");
        }

        Console.WriteLine(" ---- Fin du spam et du nettoyage ---- ");
    }
}