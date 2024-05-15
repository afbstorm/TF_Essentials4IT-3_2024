namespace _07_Héritage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(" ---- Déclaration de la FORME ---- ");
            Forme forme = new Forme();
            forme.Dessine();

            Console.WriteLine("\n ---- Déclaration du RECTANGLE ---- ");
            Rectangle rectangle = new Rectangle();
            rectangle.Dessine();

            Console.WriteLine("\n ---- Déclaration du CARRE ---- ");
            Carre carre = new Carre();
            carre.Dessine();
        }
    }
}