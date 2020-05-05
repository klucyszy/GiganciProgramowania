using System.Collections.Generic;
using System.IO;

namespace Samples.Biblioteka.Model
{
    public class LibraryRepository
    {
        public void Add(LibraryObject libraryObject)
        {
            var type = libraryObject.GetType();

            if (type == typeof(Game))
            {
                Game game = (Game)libraryObject;
                SaveToFile("G", game.Serialize());

            }
            else
            {
                Book book = (Book)libraryObject;
                SaveToFile("K", book.Serialize());
            }
        }

        public List<LibraryObject> GetItems()
        {
            if (!File.Exists(@"c:\data\library.txt"))
            {
                FileStream file = File.Create(@"c:\data\library.txt");
                file.Close();
            }

            List<LibraryObject> items = new List<LibraryObject>();
            using (var sr = new StreamReader(@"c:\data\library.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split('|');
                    if (values[0] == "G")
                    {
                        Game game = new Game(values);
                        items.Add(game);
                    }
                    else if (values[0] == "K")
                    {
                        Book book = new Book(values);
                        items.Add(book);
                    }
                }
            }

            return items;
        }

        private void SaveToFile(string type, string serializedItem)
        {
            using (var sw = new StreamWriter(@"c:\data\library.txt", true))
            {
                sw.WriteLine($"{type}|{serializedItem}");
            }
        }
    }
}
