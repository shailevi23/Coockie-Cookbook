using CoockieCookbook.Ingredients;
using CoockieCookbook.Ingredients.Dairy;
using CoockieCookbook.Ingredients.Flour;
using CoockieCookbook.Ingredients.Other;
using CoockieCookbook.Ingredients.Spices;
using System;

namespace CoockieCookbook
{
    static class Globals
    {
        public static readonly int MinId = 1;
        public static readonly int MaxId = 8;
        public const string fileName = "recpies";

        public static int StringToInt(string numricString)
        {
            return int.Parse(numricString);
        }

        public static Ingredient CreateSpecificIngredient(CoockieIngredient IngredintIdInput)
        {
            switch (IngredintIdInput)
            {
                case CoockieIngredient.WheatFlour:
                    return new WheatFlour();
                case CoockieIngredient.CoconutFlour:
                    return new CoconutFlour();
                case CoockieIngredient.Butter:
                    return new Butter();
                case CoockieIngredient.Chocolate:
                    return new Chocolate();
                case CoockieIngredient.Sugar:
                    return new Sugar();
                case CoockieIngredient.Cardamom:
                    return new Cardamom();
                case CoockieIngredient.Cinnamon:
                    return new Cinnamon();
                case CoockieIngredient.CocoaPowder:
                    return new CocoaPowder();
                default:
                    throw new ArgumentException("CoockieIngredient Dosen't exists.");
            }
        }

        public static string GetIngredientPreparingInstructions(int IngredintIdInput)
        {
            return CreateSpecificIngredient((CoockieIngredient)(IngredintIdInput-1)).ToString();
        }

        public static string FilePath(string fileType)
        {
            return $"./{fileName}.{fileType}";
        }

        public static CoockieIngredient GetEnumIngredientFromUserInput(string ingredientIdInput)
        {
            return (CoockieIngredient)(Globals.StringToInt(ingredientIdInput) - 1);
        }
    }
}
