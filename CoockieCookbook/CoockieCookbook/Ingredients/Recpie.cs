using System;
using System.Collections.Generic;

namespace CoockieCookbook.Ingredients
{
    class Recpie
    {
        public List<Ingredient> IngredientsList { get; }

        public Recpie(List<Ingredient> ingredientsRecpie)
        {
            IngredientsList = ingredientsRecpie;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, IngredientsList);
        }
    }
}
