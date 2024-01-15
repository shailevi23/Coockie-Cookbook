using System;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Recpie
    {
        readonly List<Ingredient> recpie = new List<Ingredient>();

        public Recpie(List<Ingredient> ingredientsRecpie)
        {
            recpie = ingredientsRecpie;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, recpie);
        }
    }
}
