using CoockieCookbook.Files;
using CoockieCookbook.UI.ConsoleUI;

namespace CoockieCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookBook = new Cookbook(new ConsoleHandler(), new TextFileHandler(new StringsTextualManipulation()));
            cookBook.RunApp();
        }
    }
}
