namespace CoockieCookbook.Ingredients.Flour
{
    abstract class Flour : Ingredient
    {
        public override string InstructionsOnPreparing => $"Sieve. {base.InstructionsOnPreparing}";
    }
}
