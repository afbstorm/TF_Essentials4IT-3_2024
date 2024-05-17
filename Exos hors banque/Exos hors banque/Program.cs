using Exos_hors_banque.Exceptions;
using Exos_hors_banque.Models;
using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            try
            {
                library.BorrowBook("C# Programming");

                library.ReturnBook("C# Programming", DateTime.Now.AddDays(1));

                library.BorrowBook("C# Programming");
            }
            catch (BookNotAvailableException ex)
            {
                Console.WriteLine($"BookNotAvailableException attrapée : {ex.Message}");
            }
            catch (InvalidReturnDateException ex)
            {
                Console.WriteLine($"InvalidReturnDateException attrapée : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception générique attrapée : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Opérations terminées.");
            }
        }
    }
}
