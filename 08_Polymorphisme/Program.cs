using System;
using _08_Polymorphisme.Models;

Vehicule vehicule = new Vehicule();
vehicule.SeDeplace();
Console.WriteLine(" ---- ");

Voiture voiture = new Voiture();
voiture.SeDeplace();
Console.WriteLine(" ---- ");

VoitureCourse voitureCourse = new VoitureCourse();
voitureCourse.SeDeplace();
Console.WriteLine(" ---- ");

Bateau bateau = new Bateau();
bateau.SeDeplace();
Console.WriteLine(" ---- ");

// Polymorphisme 

Console.WriteLine(" ---- Polymorphisme ---- ");

Vehicule voiture2 = new Voiture(); // Casting implicite
voiture2.SeDeplace();
Console.WriteLine(" ---- ");

Voiture newVoiture2 = (Voiture)voiture2; // Casting explicite
newVoiture2.trucMuche();
Console.WriteLine(" ---- ");

object bateau2 = new Bateau();
//bateau2.SeDeplace(); // Ne fonctionnera pas -> SeDeplace n'est pas accessible dans object
((Bateau)bateau2).SeDeplace();
Console.WriteLine(" ---- ");

Bateau bateau3 = (Bateau)bateau2;
bateau3.SeDeplace();
Console.WriteLine(" ---- ");
