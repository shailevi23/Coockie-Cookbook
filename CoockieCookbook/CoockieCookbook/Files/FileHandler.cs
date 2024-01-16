using System;
using System.Collections.Generic;
using System.IO;


namespace CoockieCookbook.Files
{
    static class FileHandler
    {
        //assume we only use json ATM
        const FileFormat fileFormat = FileFormat.Json;
        const string fileName = "recpies";

        public static void WriteToFile(Recpie recpie, List<string> recpiesList)
        {
            switch (fileFormat)
            {
                case FileFormat.Json:
                    JsonFileHandler.Write(ModifyRecpieListForJsonFile(recpie, recpiesList), FilePath(fileName));
                    break;
                case FileFormat.Text:
                    TextFileHandler.Write(ModifyRecpieListForTextFile(recpie), FilePath(fileName));
                    break;
                default:
                    throw new ArgumentException("File Format Dosen't exists.");
            }
        }

        public static List<string> ReadFromFile()
        {
            switch (fileFormat)
            {
                case FileFormat.Json:
                    return JsonFileHandler.Read<List<string>>(FilePath(fileName));
                case FileFormat.Text:
                    return TextFileHandler.Read(FilePath(fileName));
                    break;
                default:
                    throw new ArgumentException("File Format Dosen't exists.");
            }
        }

        public static bool IsFileExists()
        {
            if (File.Exists(FilePath(fileName)))
            {
                return true;
            }

            return false;
        }

        private static List<string> ModifyRecpieListForJsonFile(Recpie recpie, List<string> recpiesList)
        {
            string newRecpie = string.Join(",", recpie.GetRecpieListByIngredientId());

            if(!IsFileExists())
            {
                return new List<string> { newRecpie };
            }

            recpiesList.Add(newRecpie);
            return recpiesList;
        }

        private static string ModifyRecpieListForTextFile(Recpie recpie)
        {
            return string.Join(",", recpie.GetRecpieListByIngredientId());
        }

        private static string FilePath(string fileName)
        {
            string fileType = fileFormat == FileFormat.Json ? "json" : "txt";
            return $"./{fileName}.{fileType}";
        }
    }
}
