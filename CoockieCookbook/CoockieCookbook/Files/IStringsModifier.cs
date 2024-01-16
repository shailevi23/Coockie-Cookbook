using CoockieCookbook.Ingredients;

namespace CoockieCookbook.Files
{
    interface IStringsModifier
    {
        string ModifyRecpieFromIngredientsListToString(Recpie recpie);
    }
}
