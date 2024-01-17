using CoockieCookbook.Ingredients;
using CoockieCookbook.Ingredients.Dairy;
using CoockieCookbook.Ingredients.Flour;
using CoockieCookbook.Ingredients.Other;
using CoockieCookbook.Ingredients.Spices;
using System;

namespace CoockieCookbook.Utils
{
    class IngredientRegister
    {
        public Ingredient CreateSpecificIngredient(CoockieIngredient IngredintIdInput)
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

        public Ingredient CreateIngredientById(string ingredientIdInput)
        {
            return CreateSpecificIngredient(GetEnumIngredientFromUserInput(ingredientIdInput));
        }

        public string GetIngredientPreparingInstructions(int IngredintIdInput)
        {
            return CreateSpecificIngredient((CoockieIngredient)(IngredintIdInput - 1)).ToString();
        }

        private CoockieIngredient GetEnumIngredientFromUserInput(string ingredientIdInput)
        {
            return (CoockieIngredient)(int.Parse(ingredientIdInput) - 1);
        }
    }
}
