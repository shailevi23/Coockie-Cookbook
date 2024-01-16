using System;

namespace CoockieCookbook
{
    public enum CoockieIngredient
    {
        WheatFlour,
        CoconutFlour,
        Butter,
        Chocolate,
        Sugar,
        Cardamom,
        Cinnamon,
        CocoaPowder,
    }

    public enum FileFormat
    {
        Text,
        Json,
    }

    class Enums
    {
        public static CoockieIngredient GetEnumIngredientFromUserInput(string ingredientIdInput)
        {
            return (CoockieIngredient)(Globals.StringToInt(ingredientIdInput) - 1);
        }
    }
}
