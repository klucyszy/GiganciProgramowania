using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Biblioteka.Model
{
    public class Book : LibraryObject
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public Book(decimal price, string desc, string author, string title)
            : base(price, desc)
        {
            Author = author;
            Title = title;
        }

        public Book(string[] values) : base(values)
        {
            Title = values[3];
            Author = values[4];
        }

        public override string ToString()
        {
            return $"Kategoria: Książki | Tytuł: {Title} | Cena: {Price} PLN | Autor: {Author}";
        }

        public override string Serialize()
        {
            return $"{base.Serialize()}|{Title}|{Author}";
        }


    }
}
