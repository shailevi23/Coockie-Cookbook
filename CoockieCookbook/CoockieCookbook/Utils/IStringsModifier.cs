using CoockieCookbook.Ingredients;

namespace CoockieCookbook.Utils
{
    interface IStringsModifier
    {
        string ModifyRecpieFromIngredientsListToString(Recpie recpie);
    }
}
