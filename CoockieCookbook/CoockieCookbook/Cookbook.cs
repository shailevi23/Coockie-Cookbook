using System.Collections.Generic;

namespace CoockieCookbook
{
    class Cookbook
    {
        public void Run()
        {
            ConsoleHandler.Welcome();
            Recpie newRecpie = null;

            var ingredientsList = RunMenu();

            if (ingredientsList.Count != 0)
            {
                newRecpie = new Recpie(ingredientsList);
            }

            ConsoleHandler.RecpiePrinter(newRecpie);
            ConsoleHandler.CloseApp();
        }

        public List<Ingredient> RunMenu()
        {
            List<Ingredient> ingredientsList = new List<Ingredient>();
            string ingredientIdInput;
            bool isInputValid;

            do
            {
                //User IO in menu screen
                do
                {
                    ingredientIdInput = ConsoleHandler.MenuIO();
                    isInputValid = UserInput.IsValidate(ingredientIdInput);
                } while (isInputValid && !UserInput.IsNumricUserInputIdInRange(ingredientIdInput));

                //if user input is valid, add him to ingredients list, else,
                //exit the while loop and add the recpie if exists.
                if (isInputValid)
                {
                    var enumIngredient = Enums.GetEnumIngredientFromUserInput(ingredientIdInput);
                    ingredientsList.Add(Globals.CreateSpecificIngredient(enumIngredient));
                }
            } while (isInputValid);

            return ingredientsList;
        }
    }


}
