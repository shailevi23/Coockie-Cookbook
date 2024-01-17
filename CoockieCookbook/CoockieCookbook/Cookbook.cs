using CoockieCookbook.Files;
using CoockieCookbook.Ingredients;
using CoockieCookbook.UI;
using CoockieCookbook.UI.ConsoleUI;
using CoockieCookbook.Utils;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Cookbook
    {
        private readonly IRecpieRepository _recpieRepository;
        private readonly IUserInterface _userInterface;
        private readonly IUserInputValidator _userInputValidator;


        public Cookbook(IUserInterface userInterface,
            IRecpieRepository recpieRepository,
            IUserInputValidator userInputValidator)
        {
            _userInterface = userInterface;
            _recpieRepository = recpieRepository;
            _userInputValidator = userInputValidator;
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
                var recpiesList = _recpieRepository.Read(filePath);
                _userInterface.ShowAllRecpies(recpiesList);
            }
        }

        private List<Ingredient> RunMenuAndGetIngredientsListFromUser()
        {
            List<Ingredient> ingredientsList = new List<Ingredient>();
            string ingredientIdInput;
            bool shallContinue = true;

            while (shallContinue)
            {
                _userInterface.ShowMenu();
                ingredientIdInput = _userInterface.UserInput();
                if(_userInputValidator.IsDigit(ingredientIdInput))
                {
                    if (_userInputValidator.IsInRange(ingredientIdInput, Globals.MinId, Globals.MaxId))
                    {
                        ingredientsList.Add(_userInterface.CreateIngredientById(ingredientIdInput));
                    }
                }
                else
                {
                    shallContinue = false;
                }
            }

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
