using CoockieCookbook.Files;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Cookbook
    {
        public void RunConsoleApp()
        {
            List<string> recpiesList = GetRecpiesListIfExists();

            ConsoleHandler.Welcome();

            var ingredientsList = RunMenuAndGetIngredientsListFromUser();
            var newRecpie = CreateNewRecpieIfIngredientsListNotEmpty(ingredientsList, recpiesList);

            ConsoleHandler.PrintNewRecpieIfExists(newRecpie);
            ConsoleHandler.CloseApp();
        }

        private List<string> GetRecpiesListIfExists()
        {
            List<string> recpiesList = null;

            if (FileHandler.IsFileExists())
            {
                recpiesList = FileHandler.ReadFromFile();
                ConsoleHandler.PrintRecpiesFromFile(recpiesList);
            }

            return recpiesList;
        }

        private List<Ingredient> RunMenuAndGetIngredientsListFromUser()
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
                    isInputValid = ValidateUserInput.IsValidate(ingredientIdInput);
                } while (isInputValid && !ValidateUserInput.IsNumricUserInputIdInRange(ingredientIdInput));

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

        private Recpie CreateNewRecpieIfIngredientsListNotEmpty(List<Ingredient> ingredientsList, List<string> recpiesList)
        {
            Recpie newRecpie = null;

            if (ingredientsList.Count != 0)
            {
                newRecpie = new Recpie(ingredientsList);
                FileHandler.WriteToFile(newRecpie, recpiesList);
            }

            return newRecpie;
        }
    }


}
