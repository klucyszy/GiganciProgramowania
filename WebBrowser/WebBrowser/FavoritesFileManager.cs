using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class FavoritesFileManager
    {
        private const char splitterChar = '|';

        public string FavoritesFile { get; set; }
        public List<Favorite> Favorites { get; set; }

        public FavoritesFileManager()
        {
            Favorites = new List<Favorite>();
            FavoritesFile = Directory.GetCurrentDirectory() + "/favorites.txt";
        }

        public void ReadFromFile()
        {
            //if file not exists, create
            if (!File.Exists(FavoritesFile))
            {
                using (StreamWriter w = File.AppendText(FavoritesFile)) ;
            }

            using (StreamReader sr = new StreamReader(FavoritesFile))
            {
                string lineToRead;
                while((lineToRead = sr.ReadLine()) != null)
                {
                    string[] favoriteParts = lineToRead.Split(splitterChar); // format: favorite.Name|favorite.Url
                    Favorite favorite = new Favorite(favoriteParts[0], favoriteParts[1]);

                    Favorites.Add(favorite);
                }
            }
        }

        public void AddToFavorites(string url, string name)
        {
            Favorite favorite = new Favorite(name, url);

            SaveToFavorites(favorite);
        }

        private void SaveToFavorites(Favorite favorite)
        {
            if(favorite == null)
            {
                return;
            }

            string lineToSave = $"{favorite.Name}{splitterChar}{favorite.Url}";

            using (StreamWriter sw = new StreamWriter(FavoritesFile, true))
            {
                sw.WriteLine(lineToSave);
            }

            Favorites.Add(favorite);
        }
    }
}
