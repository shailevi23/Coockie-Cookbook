namespace CoockieCookbook
{
    static class Globals
    {
        public static readonly int MinId = 1;
        public static readonly int MaxId = 8;
        public const string fileName = "recpies";

        public static string FilePath(string fileType)
        {
            return $"./{fileName}.{fileType}";
        }
    }
}
