using System;
using System.Collections.Generic;
using System.IO;

namespace CoockieCookbook.Files
{
    class TextFileHandler
    {
        public static void Write(string obj, string filePath)
        {
            WriteToFile(obj, filePath);
        }

        public static List<string> Read(string filePath)
        {
            return ReadFileAsListOfStrings(filePath);
        }


        static void WriteToFile(string text, string filePath)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(text);
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(text);
                }
            }
        }

        static List<string> ReadFileAsListOfStrings(string filePath)
        {
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return lines;
        }
    }
}
