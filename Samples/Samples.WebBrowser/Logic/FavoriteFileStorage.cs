using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Samples.WebBrowser.Logic
{
    public class FavoriteFileStorage
    {
        private const string _path = @"C:\FileStorage\Favorites\favoriteSites.txt";

        public FavoriteFileStorage()
        {
        }

        public void Save(List<Favorite> sites)
        {
            var serialized = JsonConvert.SerializeObject(sites);
            var encodedText = Encoding.Unicode.GetBytes(serialized);

            using (FileStream sourceStream = new FileStream(_path,
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                Task.Run(() => sourceStream.WriteAsync(encodedText, 0, encodedText.Length));
            };
        }

        public List<Favorite> Read()
        {
            var result = new List<Favorite>();
            try
            {
                var stringContent = File.ReadAllText(_path);
                result = JsonConvert.DeserializeObject<List<Favorite>>(stringContent);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

    }
}
