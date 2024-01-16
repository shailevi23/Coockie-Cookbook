using CoockieCookbook.Ingredients;
using System;
using System.Collections.Generic;

namespace CoockieCookbook.UI.ConsoleUI
{
    class ConsoleHandler : IUserInterface
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void CloseApp()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        public void ShowNewRecpie(Recpie newRecpie)
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

        public void ShowMenu()
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

        public string UserInput()
        {
            return Console.ReadLine();
        }

        public void ShowAllRecpies(List<string> recpiesList)
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
    }
}
