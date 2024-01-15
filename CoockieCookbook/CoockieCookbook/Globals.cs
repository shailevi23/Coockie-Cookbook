using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoockieCookbook
{
    static class Globals
    {
        public static readonly int MinId = 1;
        public static readonly int MaxId = 8;

        public static int StringToInt(string numricString)
        {
            return int.Parse(numricString);
        }
    }
}
