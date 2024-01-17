using CoockieCookbook.Files;
using CoockieCookbook.UI.ConsoleUI;
using CoockieCookbook.Utils;

namespace CoockieCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookBook = new Cookbook(new ConsoleUI(),
                new TextFileHandler(new StringsTextualManipulation()),
                new UserInputValidator());
            cookBook.RunApp();
        }
    }
}
