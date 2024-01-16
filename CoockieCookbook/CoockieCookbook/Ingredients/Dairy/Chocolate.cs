namespace CoockieCookbook.Ingredients.Dairy
{
    class Chocolate : Ingredient
    {
        public override int Id => 4;
        public override string Name => "Chocolate";
        public override string InstructionsOnPreparing => $"Melt in a water bath. {base.InstructionsOnPreparing}";
    }
}
