namespace CoockieCookbook.Ingredients.Dairy
{
    class Chocolate : Ingredient
    {
        public Chocolate()
        {
            this.Id = 4;
            this.Name = "Chocolate";
            this.InstructionsOnPreparing = "Melt in a water bath. " + this.InstructionsOnPreparing;
        }
    }
}
