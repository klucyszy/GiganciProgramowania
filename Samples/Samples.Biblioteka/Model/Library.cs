using System;
using System.Collections.Generic;
using System.IO;
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

        public List<Game> GetGames()
        {
            return Games;
        }

        public void ImportGamesFromFile()
        {
            Games.Clear();

            using (var sr = new StreamReader(@"c:\data\games.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var values = line.Split('|');
                    var title = values[0];
                    var price = int.Parse(values[2]);
                    var description = values[3];
                    var minimumAge = int.Parse(values[1]);
                    var game = new Game(price, description, minimumAge, title);

                    AddGame(game);
                }
            }
        }

        public void SaveGamesToFile()
        {
            using (var sw = new StreamWriter(@"c:\data\games.txt"))
            {
                foreach(var game in Games)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}", game.Title, game.MinimumAge, game.Price, game.Description);
                }
            }
        }
    }
}
