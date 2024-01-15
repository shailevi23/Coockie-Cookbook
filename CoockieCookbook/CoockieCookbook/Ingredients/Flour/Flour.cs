namespace CoockieCookbook.Ingredients.Flour
{
    class Flour : Ingredient
    {
        public Flour()
        {
            this.InstructionsOnPreparing = "Sieve. " + this.InstructionsOnPreparing;
        }
    }
}
