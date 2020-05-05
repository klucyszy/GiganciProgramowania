using System.Collections.Generic;
using System.IO;

namespace WebBrowser
{
    public class FavoritesFileRepository
    {
        const string FileName = "favorites.txt";
        private string FavoritesFile;

        public FavoritesFileRepository()
        {
            FavoritesFile = $"{Directory.GetCurrentDirectory()}/{FileName}";
        }

        public List<Favorite> Get()
        {
            var favorites = new List<Favorite>();
            
            if (!File.Exists(FavoritesFile))
            {
                File.Create(FavoritesFile);
            }

            using (StreamReader sr = new StreamReader(FavoritesFile))
            {
                string lineToRead;
                while ((lineToRead = sr.ReadLine()) != null)
                {
                    string[] favoriteParts = lineToRead.Split('|'); // format: favorite.Name|favorite.Url
                    Favorite favorite = new Favorite(favoriteParts[0], favoriteParts[1]);

                    favorites.Add(favorite);
                }
            }

            return favorites;
        }

        public void Add(Favorite favorite)
        {
            if (favorite == null)
            {
                return;
            }

            if (!File.Exists(FavoritesFile))
            {
                File.Create(FavoritesFile);
            }

            using (StreamWriter sw = new StreamWriter(FavoritesFile, true))
            {
                sw.WriteLine($"{favorite.Name}|{favorite.Url}");
            }
        }
    }
}
