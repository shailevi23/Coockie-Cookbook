using System;

namespace CoockieCookbook
{
    class Enums
    {
        public enum Ingredient
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

        public static Enums.Ingredient GetEnumIngredientFromUserInput(string ingredientIdInput)
        {
            return (Enums.Ingredient)(Globals.StringToInt(ingredientIdInput) - 1);
        }
    }
}
