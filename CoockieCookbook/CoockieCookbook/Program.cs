using CoockieCookbook.Ingredients.Dairy;
using CoockieCookbook.Ingredients.Flour;
using CoockieCookbook.Ingredients.Other;
using CoockieCookbook.Ingredients.Spices;
using System;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
            List<Ingredient> ingredientsList = new List<Ingredient>();
            string ingredientIdInput;
            bool isInputValid;

            do
            {
                do
                {
                    PrintMenu();
                    ingredientIdInput = Console.ReadLine();
                    isInputValid = UserInput.IsValidate(ingredientIdInput);
                } while (isInputValid && !UserInput.IsNumricUserInputIdInRange(ingredientIdInput));

                //if input is valid, add him to ingredients list, else, exit the while loop and add the recpie if exists.
                if(isInputValid)
                {
                    var enumIngredient = Enums.GetEnumIngredientFromUserInput(ingredientIdInput);
                    ingredientsList.Add(GetSpecificIngredient(enumIngredient));
                }
            } while (isInputValid);

            AddRecpieToListAndPrintToConsole(ingredientsList);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        static void AddRecpieToListAndPrintToConsole(List<Ingredient> ingredientsList)
        {
            if (ingredientsList.Count == 0)
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }
            else
            {
                var newRecpie = new Recpie(ingredientsList);
                Console.WriteLine("Recipe added:");
                Console.WriteLine(newRecpie.ToString());
            }
        }

        static Ingredient GetSpecificIngredient(Enums.Ingredient IngredintIdInput)
        {
            switch (IngredintIdInput)
            {
                case Enums.Ingredient.WheatFlour:
                    return new WheatFlour();
                case Enums.Ingredient.CoconutFlour:
                    return new CoconutFlour();
                case Enums.Ingredient.Butter:
                    return new Butter();
                case Enums.Ingredient.Chocolate:
                    return new Chocolate();
                case Enums.Ingredient.Sugar:
                    return new Sugar();
                case Enums.Ingredient.Cardamom:
                    return new Cardamom();
                case Enums.Ingredient.Cinnamon:
                    return new Cinnamon();
                case Enums.Ingredient.CocoaPowder:
                    return new CocoaPowder();
                default:
                    throw new ArgumentException("Ingredient Dosen't exists.");
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
