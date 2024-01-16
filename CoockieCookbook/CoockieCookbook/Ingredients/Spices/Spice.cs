namespace CoockieCookbook.Ingredients.Spices
{
    abstract class Spice : Ingredient
    {
        public override string InstructionsOnPreparing => $"Take half a teaspoon. {base.InstructionsOnPreparing}";
    }
}
