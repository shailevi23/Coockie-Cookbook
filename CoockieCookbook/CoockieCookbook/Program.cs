using CoockieCookbook.Ingredients.Dairy;
using CoockieCookbook.Ingredients.Flour;
using CoockieCookbook.Ingredients.Other;
using CoockieCookbook.Ingredients.Spices;
using System;
using System.Collections.Generic;

namespace CoockieCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookBook = new Cookbook();
            cookBook.Run();
        }
    }
}
