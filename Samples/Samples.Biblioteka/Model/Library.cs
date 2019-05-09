using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Biblioteka.Model
{
    public class Library
    {
        public List<Game> Games { get; private set; }

        public Library()
        {
            Games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            if (!Games.Contains(game))
            {
                Games.Add(game);
            }
        }

        public void RemoveGame(Game game)
        {
            Games.Remove(game);
        }
    }
}
