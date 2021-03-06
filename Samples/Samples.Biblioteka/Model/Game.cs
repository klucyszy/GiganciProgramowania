﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Biblioteka.Model
{
    public class Game : LibraryObject
    {
        public int MinimumAge { get; set; }
        public string Title { get; set; }

        public Game(decimal price, string desc, int minAge, string title)
            : base(price, desc)
        {
            MinimumAge = minAge;
            Title = title;
        }

        public Game(string[] values) : base(values)
        {
            Title = values[3];
            MinimumAge = int.Parse(values[4]);
        }

        public override string ToString()
        {
            return $"Kategoria: Gry | Tytuł: {Title} | Cena: {Price} PLN | Wiek: {MinimumAge}+";
        }

        public override string Serialize()
        {
            return $"{base.Serialize()}|{Title}|{MinimumAge}";
        }
    }
}
