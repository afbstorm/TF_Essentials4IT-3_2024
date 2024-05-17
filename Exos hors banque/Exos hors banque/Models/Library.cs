using Exos_hors_banque.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_hors_banque.Models
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public Library()
        {
            books.Add(new Book("C# Programming"));
            books.Add(new Book("Learn ASP.NET Core"));
            books.Add(new Book("Mastering LINQ"));
        }

        // Méthode pour emprunter un livre
        public void BorrowBook(string title)
        {
            Book book = books.Find(b => b.Title == title);

            if (book == null)
            {
                throw new BookNotAvailableException("Le livre n'est pas disponible dans la bibliothèque.");
            }

            if (!book.IsAvailable)
            {
                throw new BookNotAvailableException("Le livre est déjà emprunté.");
            }

            book.IsAvailable = false;
            Console.WriteLine($"Vous avez emprunté le livre : {title}");
        }

        // Méthode pour retourner un livre
        public void ReturnBook(string title, DateTime returnDate)
        {
            Book book = books.Find(b => b.Title == title);

            if (book == null)
            {
                throw new BookNotAvailableException("Le livre n'est pas disponible dans la bibliothèque.");
            }

            if (returnDate > DateTime.Now)
            {
                throw new InvalidReturnDateException("La date de retour ne peut pas être dans le futur.");
            }

            book.IsAvailable = true;
            Console.WriteLine($"Vous avez retourné le livre : {title}");
        }
    }
}
