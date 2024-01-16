namespace CoockieCookbook.Ingredients
{
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string InstructionsOnPreparing => "Add to other ingredients.";

        public override string ToString()
        {
            return Name + ". " + InstructionsOnPreparing;
        }
    }
}