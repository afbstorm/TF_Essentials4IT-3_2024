//// ---------------- Événement ---------------------- //

//using System;

//public class Publisher
//{
//    // Déclaration d'un événement de type EventHandler
//    public event EventHandler DataReceived;

//    // Déclaration d'une méthode RaiseEvent()
//    // Utilisée pour déclencher l'événement. Elle vérifie s'il y a des abonnées. S'il y en a elle déclenche l'événement en appelant DataReceived
//    public void RaiseEvent()
//    {
//        if (DataReceived != null)
//        {
//            // Déclenche l'événement en passant l'instance actuelle (this) en tant qu'expéditeur (sender) et EventArgs.Empty comme arguments
//            DataReceived(this, EventArgs.Empty);
//        }
//    }
//}

//class Subscriber
//{
//    // Méthode OnDataReceived : gère l'événement DataReceived
//    // Elle est appelée lorsqu'un événement DataReceived est déclenché par un éditeur (Publisher)
//    public void OnDataReceived(object sender, EventArgs e)
//    {
//        Console.WriteLine("Event received by Subscriber.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Publisher publisher = new Publisher();
//        Subscriber subscriber = new Subscriber();
//        // Abonnement du gestionnaire d'événements OnDataReceived au Publisher
//        publisher.DataReceived += subscriber.OnDataReceived;
//        // Déclenchement de l'événement par le Publisher, ce qui va appeler le gestionnaire d'événements associé
//        publisher.RaiseEvent();
//    }
//}


//// ---------------- Événement 2---------------------- //

//using System;

//public class CustomEventArgs : EventArgs
//{
//    // Propriété Data pour stocker la donnée à transmettre lors de l'événement. La propriété est en lecture seule en dehors de la classe.
//    public int Data { get; private set; }

//    // Constructeur qui initialise la propriété Data avec la valeur passée en paramètre.
//    public CustomEventArgs(int data)
//    {
//        Data = data;
//    }
//}

//public class Publisher
//{
//    // Déclaration de l'événement DataProcessed de type EventHandler avec des arguments de type CustomEventArgs.
//    public event EventHandler<CustomEventArgs> DataProcessed;

//    // Méthode pour traiter des données et déclencher l'événement.
//    public void ProcessData(int value)
//    {
//        // Création et passage d'une instance de CustomEventArgs à la méthode OnDataProcessed pour notifier les abonnés.
//        OnDataProcessed(new CustomEventArgs(value));
//    }

//    // Méthode protégée et virtuelle pour permettre la surcharge dans les classes dérivées. Elle déclenche l'événement DataProcessed.
//    protected virtual void OnDataProcessed(CustomEventArgs e)
//    {
//        // Vérifie si des abonnés sont présents avant de déclencher l'événement.
//        if (DataProcessed != null)
//        {
//            // Déclenche l'événement en passant l'instance actuelle (this) et les arguments de l'événement (e).
//            DataProcessed(this, e);
//        }
//    }
//}

//class Subscriber
//{
//    // Méthode pour gérer l'événement DataProcessed.
//    public void OnDataProcessed(object sender, CustomEventArgs e)
//    {
//        Console.WriteLine($"Processed data: {e.Data}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Publisher publisher = new Publisher();
//        Subscriber subscriber = new Subscriber();

//        // Abonnement de la méthode OnDataProcessed du Subscriber à l'événement DataProcessed du Publisher.
//        publisher.DataProcessed += subscriber.OnDataProcessed;

//        // Appel de la méthode ProcessData pour traiter les données et déclencher l'événement.
//        publisher.ProcessData(42);
//    }
//}


//// ---------------- Type Générique ---------------------- //

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine(Add<int>(5, 10));
//        Console.WriteLine(Add<double>(5.5, 10.2));
//    }

//    static T Add<T>(T a, T b)
//    {
//        return (dynamic)a + (dynamic)b;
//    }
//}

//// ---------------- Type Générique ---------------------- //

//using System;

//// GenericList<T> est une classe générique avec le type T qui représente le type des éléments stockés.
//public class GenericList<T>
//{
//    // Déclaration de la propriété elements qui va être un tableau de T
//    private T[] elements;
//    private int count = 0;

//    // Constructeur qui va prendre une taille en paramètre et l'utiliser pour déclarer la taille du tableau de T
//    public GenericList(int size)
//    {
//        elements = new T[size];
//    }

//    // Méthode qui va ajouter des éléments au tableau de T
//    public void Add(T element)
//    {
//        if (count < elements.Length)
//        {
//            elements[count++] = element;
//        }
//    }

//    // Méthode qui va récupérer des éléments par leur index depuis le tableau de T
//    public T Get(int index)
//    {
//        return elements[index];
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        GenericList<string> ListDeTrucs = new GenericList<string>(5);
//        ListDeTrucs.Add("Champion");
//        ListDeTrucs.Add("Boulet");
//        Console.WriteLine(ListDeTrucs.Get(0));
//        Console.WriteLine(ListDeTrucs.Get(1));
//    }
//}