using System;
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
        public string  Title { get; set; }

        public Game(decimal price, string desc, int minAge, string title) 
            : base(price, desc)
        {
            MinimumAge = minAge;
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }

        public void SaveToFile()
        {
            using (var sw = new StreamWriter(@"c:\games.txt", true))
            {
                sw.WriteLine("{0}|{1}|{2}|{3}", Title, MinimumAge, Price, Description);
            }
        }
    }
}
