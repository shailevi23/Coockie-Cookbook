using System;

namespace CoockieCookbook
{
    public abstract class Ingredient
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        protected string InstructionsOnPreparing { get; set; } = "Add to other ingredients.";

        public override string ToString()
        {
            return Name + ". " + InstructionsOnPreparing;
        }
    }
}