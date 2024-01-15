using System;

namespace CoockieCookbook.Ingredients.Dairy
{
    class Butter : Ingredient
    {
        public Butter()
        {
            this.Id = 3;
            this.Name = "Butter";
            this.InstructionsOnPreparing = "Melt on low heat. " + this.InstructionsOnPreparing;
        }
    }
}
