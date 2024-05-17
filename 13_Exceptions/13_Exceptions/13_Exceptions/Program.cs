//class Program
//{
//    public void ExampleTryCatch()
//    {
//        try
//        {
//            // Processus
//            // Si erreur dans le process, on transfère au catch
//        } catch (Exception ex)
//        {
//            // Process l'erreur
//        } finally
//        {
//            // Effectue une action a la fin de tout
//        }
//    }
//}

//// " ---- Exception exemple 1 ---- " //

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Le bloc try va tenter d'exécuter du code, on essaie dans cet exemple d'accèder à la valeu de l'index spécifié
//        try
//        {

//            int[] array = {1,2,3};
//            Console.WriteLine(array[2]);

//        } 
//        // Le bloc catch va capturer l'exception IndexOutOfRangeException et nous afficher le message d'erreur associé
//        catch (IndexOutOfRangeException err) 
//        {
//            Console.WriteLine($"Exception caught : {err.Message}");
//        } catch (Exception err)
//        {
//            Console.WriteLine($"General exception caught : {err.Message}");
//        }
//        // Le bloc finally va exécuter du code quoi qu'il se soit passé dans les blocs try / catch
//        finally
//        {
//            Console.WriteLine("Code execution completed");
//        }
//    }
//}

// " ---- Exception exemple 2 (custom) ---- " //

using System;

class SoldeInsuffisantException : Exception
{
    public SoldeInsuffisantException(string message): base(message) {}
}

class Compte
{
    public double Solde { get; private set; } = 400;

    public void Retirer(double montant)
    {
        if (montant > Solde)
        {
            // Différence avec le bloc try / catch est que pour les exceptions custom, nous devons indiquer un message
            throw new SoldeInsuffisantException($"Votre solde est insuffisant.");
        }

        Solde -= montant;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Compte compte = new Compte();
        try
        {
            compte.Retirer(500);
        } catch (SoldeInsuffisantException err)
        {
            Console.WriteLine($"Exception caught : {err.Message}, mettez plus d'argent sur votre compte pour effectuer cette opération.");
        }
    }
}
