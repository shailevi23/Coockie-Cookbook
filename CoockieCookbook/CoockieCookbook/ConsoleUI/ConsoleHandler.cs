using CoockieCookbook.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoockieCookbook
{
    static class ConsoleHandler
    {
        public static void Welcome()
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        }

        public static void CloseApp()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public static void PrintNewRecpieIfExists(Recpie newRecpie)
        {
            if (newRecpie is null)
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }
            else
            {
                Console.WriteLine("Recipe added:");
                Console.WriteLine(newRecpie.ToString());
            }
        }

        public static string MenuIO()
        {
            PrintMenu();
            return Console.ReadLine();
        }

        public static void PrintRecpiesFromFile(List<string> recpiesList)
        {
            Console.WriteLine("Existing recipes are:");

            for(int i = 1; i <= recpiesList.Count; i++)
            {
                Console.WriteLine($"*****{i}*****");
                List<int> recpiesListOfIntegers = new List<int>(Array.ConvertAll(recpiesList[i-1].Split(','), s => int.Parse(s)));
                foreach (int recpieId in recpiesListOfIntegers)
                {
                    Console.WriteLine(Globals.GetIngredientPreparingInstructions(recpieId));
                }
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine(@"1.Wheat flour
2.Coconut flour
3.Butter
4.Chocolate
5.Sugar
6.Cardamom
7.Cinnamon
8.Cocoa powder");
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
        }
    }
}
