using CoockieCookbook.Files;
using CoockieCookbook.Ingredients;
using CoockieCookbook.UI;
using CoockieCookbook.UI.ConsoleUI;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Cookbook
    {
        private readonly IRecpieRepository _recpieRepository;
        private readonly IUserInterface _userInterface;

        public Cookbook(IUserInterface iUserInterface, IRecpieRepository iRecpieRepository)
        {
            _userInterface = iUserInterface;
            _recpieRepository = iRecpieRepository;
        }

        public void RunApp()
        {
            ShowRecpiesListIfExists();

            _userInterface.ShowMessage("Create a new cookie recipe!Available ingredients are: ");

            var ingredientsList = RunMenuAndGetIngredientsListFromUser();
            var newRecpie = CreateNewRecpieIfIngredientsListNotEmpty(ingredientsList);

            _userInterface.ShowNewRecpie(newRecpie);
            _userInterface.CloseApp();
        }

        private void ShowRecpiesListIfExists()
        {
            string filePath = _recpieRepository.GetRepoPath();
            if (_recpieRepository.IsRepoExists(filePath))
            {
                List<string> recpiesList = _recpieRepository.Read(filePath);
                _userInterface.ShowAllRecpies(recpiesList);
            }
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
                    _userInterface.ShowMenu();
                    ingredientIdInput = _userInterface.UserInput();
                    isInputValid = ValidateUserInput.IsValidate(ingredientIdInput);
                } while (isInputValid && !ValidateUserInput.IsNumricUserInputIdInRange(ingredientIdInput));

                //if user input is valid, add him to ingredients list, else,
                //exit the while loop and add the recpie if exists.
                if (isInputValid)
                {
                    var enumIngredient = Globals.GetEnumIngredientFromUserInput(ingredientIdInput);
                    ingredientsList.Add(Globals.CreateSpecificIngredient(enumIngredient));
                }
            } while (isInputValid);

            return ingredientsList;
        }

        private Recpie CreateNewRecpieIfIngredientsListNotEmpty(List<Ingredient> ingredientsList)
        {
            Recpie newRecpie = null;

            if (ingredientsList.Count != 0)
            {
                newRecpie = new Recpie(ingredientsList);
                _recpieRepository.Write(newRecpie, _recpieRepository.GetRepoPath());
            }

            return newRecpie;
        }
    }


}
