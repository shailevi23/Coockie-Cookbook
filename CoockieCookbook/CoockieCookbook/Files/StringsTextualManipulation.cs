using CoockieCookbook.Ingredients;
using System.Collections.Generic;

namespace CoockieCookbook.Files
{
    class StringsTextualManipulation : IStringsModifier
    {
        public string ModifyRecpieFromIngredientsListToString(Recpie recpie)
        {
            List<string> res = new List<string>();
            List<Ingredient> ingredients = recpie.IngredientsList;
            foreach (Ingredient ingredient in ingredients)
            {
                res.Add(ingredient.Id.ToString());
            }
            return string.Join(",", res);
        }
    }
}
