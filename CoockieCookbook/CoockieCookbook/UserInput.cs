namespace CoockieCookbook
{
    static class UserInput
    {
        public static bool IsValidate(string input)
        {
            return int.TryParse(input, out int res);
        }

        public static bool IsNumricUserInputIdInRange(string input)
        {
            int idInput = Globals.StringToInt(input);
            if (idInput >= Globals.MinId && idInput <= Globals.MaxId)
            {
                return true;
            }

            return false;
        }
    }
}
