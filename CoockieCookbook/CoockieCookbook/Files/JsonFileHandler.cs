using CoockieCookbook.Ingredients;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CoockieCookbook.Files
{
    class JsonFileHandler : IRecpieRepository
    {
        private readonly IStringsModifier _stringsModifier;

        public JsonFileHandler(IStringsModifier stringsModifier)
        {
            _stringsModifier = stringsModifier;
        }

        public void Write(Recpie recpie, string filePath)
        {
            var newRecpie = _stringsModifier.ModifyRecpieFromIngredientsListToString(recpie);
            var recpiesList = Read(filePath);
            if (recpiesList == null)
            {
                recpiesList = new List<string> { newRecpie };
            }
            else
            {
                recpiesList.Add(newRecpie);
            }
            var jsonString = JsonSerializer.Serialize(recpiesList);
            File.WriteAllText(filePath, jsonString);
        }

        public List<string> Read(string filePath)
        {
            string text = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(text);
        }

        public bool IsRepoExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                return true;
            }

            return false;
        }

        public string GetRepoPath()
        {
            return Globals.FilePath("json");
        }
    }
}
