using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exos_hors_banque.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title)
        {
            Title = title;
        }
    }
}
