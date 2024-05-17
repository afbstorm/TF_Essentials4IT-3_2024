//// ---- Différentes formes de fonctions ---- //

//// Func 0:X Params => 1 return (string, int, bool)

//// Action 0:X Params => 0 return (void)

//// Predicate 0:X Params => 1 return bool

//// ---- On déclare une fonction avec le mot-clé Func, le dernier type de la fonction EST le type de RETOUR
//// Lambda expression
//Func<string, bool, int> a = (string msg, bool verite) =>
//{
//    if (msg == "Hello" && bool == true)
//    {
//        return 42;
//    }
//};

//// ---- On déclare une action avec le mot-clé Action il n'y a PAS de type de retour

//Action<string, bool, int> b = (string msg, bool verite, int nombre) =>
//{
//    Console.WriteLine(msg);
//};

//// ---- Un prédicat est un type de fonction qui ne retourne JAMAIS QUE un booléen

//Predicate<int> c (int nombre) => 
//{
//    return true;
//};

//// SAME SAME BUT DIFFERENT
//Func<int, bool> d = (int nombre) =>
//{
//    return false;
//};

//// ---- Exemple delegate  ---- //

//// On va déclarer une Liste d'ampoules de type Ampoule
//List<Ampoule> ampoules = new List<Ampoule>();
//// On va déclarer une propriété interrupteur de type Interrupteur
//Interrupteur interrupteur = new Interrupteur();

//// On va créer une boucle qui va instancier et stocker 10 ampoules dans notre delegate
//for (int i = 1; i <= 10; i++)
//{
//    Ampoule ampoule = new Ampoule(i.ToString());
//    // Stocke à chaque itération dans le delegate EnclencherInterrupteur une ampoule
//    interrupteur.EnclencherInterrupteur += ampoule.Allumer;
//}

//// On appele la méthode Allumer() de l'interrupteur qui va déclencher les méthodes stockées dans le delegate
//interrupteur.Allumer();


//public class Ampoule
//{
//    public string Name { get; set; }

//    public Ampoule(string name)
//    {
//        Name = name;
//    }

//    public bool Allumer()
//    {
//        Console.WriteLine($"L'ampoule {Name} est allumée");
//        return true;
//    }
//};

//// On déclare la class Interrupteur et on y déclare un delegate de type booléen, ainsi qu'une propriété du type du delegate
//// qui a l'appel (invoke) utilisera les pointeurs stockés

//public class Interrupteur
//{
//    // Déclaration du delegate - Prototype de delegate
//    public delegate bool EnclencherInterrupteurDelegate();
//    // Déclaration de la propriété qui va permettre l'appel du delegate
//    public EnclencherInterrupteurDelegate EnclencherInterrupteur = null;

//    // Méthode Allumer() pour INVOKE notre propriété contenant le delegate
//    public void Allumer()
//    {
//        // EnclencherInterrupteur.Invoke()
//        EnclencherInterrupteur();
//    }
//};


//// ---- Exemple delegate 2 ---- //

//// Déclare un delegate qui va prendre un string en paramètre. Ce paramètre sera obligatoire pour chaque utilisation de l'instanciation de notre delegate
//public delegate void ProcessBookDelegate(string title);

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Déclaration d'une propriété du type ProcessBookDelegate
//        ProcessBookDelegate printTitleDelegate = PrintTitle;
//        // On appele la méthode qui reçoit notre delegate en paramètre et l'utilise comme callback
//        ProcessBooks(printTitleDelegate);

//    }

//    static void PrintTitle(string title)
//    {
//        Console.WriteLine(title);
//    }
//    // Callback -> printTitleDelegate contient une méthode et est appelé dans les paramètres d'une méthode / fonction
//    // ProcessBooks(PrintTitle(Trolilol)) {}
//    static void ProcessBooks(ProcessBookDelegate processBookDelegate)
//    {
//        string[] books = { "Le Seigneur des anneaux", "No Pasaran", "Solo Leveling" };
//        foreach (string book in books)
//        {
//            processBookDelegate(book);
//        }
//    }
//}

//// Étape 1 : 
//public delegate void ProcessBookDelegate(string title);

//// Étape 2 :
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Étape 4 :
//        ProcessBookDelegate ProcessBook = PrintTitle;
//        // Étape 6 :
//        ProcessBooksTitles(ProcessBook);
//    }

//    // Étape 3 : 
//    static void PrintTitle(string title)
//    {
//        Console.WriteLine(title);
//    }

//    // Étape 5
//    static void ProcessBooksTitles(ProcessBookDelegate processBookParam)
//    {
//        string[] books = { "Le Seigneur des anneaux", "No Pasaran", "Solo Leveling" };
//        foreach (string book in books)
//        {
//            processBookParam(book);
//        }
//    }
//}

public delegate void NotifyDelegate(string message);

class Program
{
    static void Main(string[] args)
    {
        NotifyDelegate Notify = NotifyByEmail;
        Notify += NotifyBySMS;
        Notify("Hello, comment vas-tu ?");
    }

    static void NotifyByEmail(string message)
    {
        string methodName = nameof(NotifyByEmail);
        Console.WriteLine($"Vous avez reçu un message : {message} - Notification envoyée par {methodName}");
    }

    static void NotifyBySMS(string message)
    {
        string methodName = nameof(NotifyBySMS);
        Console.WriteLine($"Vous avez reçu un message : {message} - Notification envoyée par {methodName}");
    }
}