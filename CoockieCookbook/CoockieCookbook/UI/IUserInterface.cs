using CoockieCookbook.Ingredients;
using System.Collections.Generic;

namespace CoockieCookbook.UI
{
    interface IUserInterface
    {
        void ShowMessage(string message);
        void CloseApp();
        void ShowMenu();
        void ShowAllRecpies(List<string> recpiesList);
        void ShowNewRecpie(Recpie newRecpie);
        string UserInput();
        Ingredient CreateIngredientById(string ingredientId);
    }
}
