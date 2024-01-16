namespace CoockieCookbook.Ingredients.Dairy
{
    class Butter : Ingredient
    {
        public override int Id => 3;
        public override string Name => "Butter";
        public override string InstructionsOnPreparing => $"Melt on low heat. {base.InstructionsOnPreparing}";
    }
}
