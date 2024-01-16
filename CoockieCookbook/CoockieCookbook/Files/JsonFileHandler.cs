using System.IO;
using System.Text.Json;

namespace CoockieCookbook.Files
{
    static class JsonFileHandler
    {
        public static void Write(object obj, string filePath)
        {
            var jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, jsonString);
        }

        public static T Read<T>(string filePath)
        {
            string text = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(text);
        }
    }
}
