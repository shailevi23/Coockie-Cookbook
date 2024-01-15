namespace CoockieCookbook.Ingredients.Spices
{
    class Spice : Ingredient
    {
        public Spice()
        {
            this.InstructionsOnPreparing = "Take half a teaspoon. " + this.InstructionsOnPreparing;
        }
    }
}
