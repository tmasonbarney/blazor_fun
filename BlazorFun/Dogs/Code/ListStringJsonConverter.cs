using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dogs.Code
{
    public class ListStringJsonConverter : IListStringJsonConverter
    {

        public List<string> GetDogsFromResult(string json)
        {
            var options = new JsonDocumentOptions
            {
                AllowTrailingCommas = true
            };

            using JsonDocument document = JsonDocument.Parse(json, options);

            var breeds = new List<string>();

            var rootElement = document.RootElement.EnumerateObject();

            var jsonElement = rootElement.First().Value.EnumerateObject();

            foreach (var element in jsonElement)
            {
                var breed = element.Name;

                breeds.Add(breed);

                var subBreeds = element.Value.EnumerateArray();

                if (!subBreeds.Any()) continue;

                foreach (var subBreed in subBreeds)
                {
                    breeds.Add(subBreed.GetString());
                }

            }

            return breeds;
        }
  
    }
}
