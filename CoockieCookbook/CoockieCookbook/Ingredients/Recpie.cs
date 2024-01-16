using System;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Recpie
    {
        readonly List<Ingredient> recpie;

        public Recpie(List<Ingredient> ingredientsRecpie)
        {
            recpie = ingredientsRecpie;
        }

        public List<string> GetRecpieListByIngredientId()
        {
            List<string> res = new List<string>();
            foreach (Ingredient ingredient in recpie)
            {
                res.Add(ingredient.Id.ToString());
            }
            return res;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, recpie);
        }
    }
}
