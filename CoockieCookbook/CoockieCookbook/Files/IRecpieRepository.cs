using CoockieCookbook.Ingredients;
using System.Collections.Generic;

namespace CoockieCookbook.Files
{
    interface IRecpieRepository
    {
        void Write(Recpie recpie, string filePath);
        List<string> Read(string filePath);
        bool IsRepoExists(string filePath);
        string GetRepoPath();
    }
}
