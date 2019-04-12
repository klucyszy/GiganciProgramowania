using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.WebBrowser.Logic
{
    public class FavoritesRepository
    {
        private readonly FavoriteFileStorage _fileStorage;

        public ObservableCollection<Favorite> Favorites { get; set; }

        public FavoritesRepository()
        {
            _fileStorage = new FavoriteFileStorage();
            Favorites = new ObservableCollection<Favorite>(_fileStorage.Read());
        }

        public void Add(string siteName, string siteUrl)
        {
            //TODO: Check if siteUrl is already in list
            Favorites.Add(new Favorite(siteName, siteUrl));

            _fileStorage.Save(Favorites.ToList());
        }

        public ObservableCollection<Favorite> Get()
        {
            return Favorites;
        }

        //TODO: Add Remove()
    }

    public class Favorite
    {
        public string SiteName { get; set; }
        public Uri SiteUrl { get; set; }

        public Favorite(string siteName, string siteUrl)
        {
            SiteName = siteName;
            SiteUrl = new Uri(siteUrl);
        }

        public override string ToString()
        {
            return SiteName;
        }
    }
}
