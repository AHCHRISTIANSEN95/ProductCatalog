using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace ProductsLibrary
{
    public static class Database
    {
        public static List<Drama> GetDramas(string path)
        {
            var jsonData = File.ReadAllText("data/drama_movies.json");
            var result = JsonConvert.DeserializeObject<List<Drama>>(jsonData);
            return result;
        }

        public static List<Adventure> GetAdventures(string path)
        {
            var jsonData = File.ReadAllText("data/Adventure_movies.json");
            var result = JsonConvert.DeserializeObject<List<Adventure>>(jsonData);
            return result;
        }

        public static List<Horror> GetHorrors(string path)
        {
            var jsonData = File.ReadAllText("data/Horror_movies.json");
            var result = JsonConvert.DeserializeObject<List<Horror>>(jsonData);
            return result;
        }

    }
}
